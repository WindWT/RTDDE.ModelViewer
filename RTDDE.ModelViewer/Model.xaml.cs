﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using DDSReader;
using HelixToolkit.Wpf;
using RTDDE.ModelViewer;

//using RTDDE.Provider;

namespace RTDDE.ModelViewer
{
    public partial class Model : UserControl
    {
        public Model()
        {
            InitializeComponent();
        }
        private class ModelInfo
        {
            public int g_id;
            public string modelName;
            public string GetFileName()
            {
                return ((g_id - 1) / 10 * 10 + 1).ToString() + "-" + (((g_id - 1) / 10 + 1) * 10).ToString();
            }
            public string GetUnity3DFilePath()
            {
                return string.Format(@"model\{0}.unity3d", GetFileName());
            }
            public string GetModelDirectory()
            {
                return string.Format(@"model\{0}", GetFileName());
            }
            public ModelInfo() :
                this(0, string.Empty) { }
            public ModelInfo(int i, string s)
            {
                g_id = i;
                modelName = s;
            }
        }
        private ModelInfo modelInfo = new ModelInfo();
        public void Load(int g_id, string model)
        {
            lock (modelInfo) {
                LoadingMask.Visibility = Visibility.Visible;
                modelInfo = new ModelInfo(g_id, model);
                //List<string> fileList = InitModelFile(modelInfo);
                Task<List<string>> taskInitModelFile = new Task<List<string>>(() => InitModelFile(modelInfo));
                taskInitModelFile.ContinueWith(t =>
                    {
                        try {
                            InitModel(t.Result);
                        }
                        catch (Exception ex) {
                            File.Delete(modelInfo.GetUnity3DFilePath());
                            Directory.Delete(modelInfo.GetModelDirectory(), true);
                            //Utility.ShowException(ex.Message);
                        }
                    }, MainWindow.UiTaskScheduler);
                taskInitModelFile.Start();
            }
        }
        public void Unload()
        {
            model.Content = null;
            LoadingMask.Visibility = Visibility.Visible;
        }
        private List<string> InitModelFile(ModelInfo info)
        {
            //if (AssetBundleDefine.m_BasicBundles.Any(o => o.fileName == modelInfo.GetFileName()) == false) {
                return new List<string>();
            //}
            //AssetBundleDefine.AssetBundleInfo abi = AssetBundleDefine.m_BasicBundles.First(o => o.fileName == modelInfo.GetFileName());
            //if (Directory.Exists("model") == false) {
            //    Directory.CreateDirectory("model");
            //}
            ////first find exist model file
            //List<string> fileList = GetUnpackFile(modelInfo);
            //if (fileList.Count > 0) {
            //    return fileList;
            //}
            //else if (string.IsNullOrEmpty(Settings.Config.Model.DisunityPath)) {
            //    //disable unpack & download if no disunity
            //    return fileList;
            //}
            //else if (File.Exists(info.GetUnity3DFilePath())) {
            //    //find unity3d file, then extract
            //    UnpackFile(modelInfo);
            //    return GetUnpackFile(modelInfo);
            //}
            //else {
            //    //download,extract,return
            //    using (WebClient client = new WebClient()) {
            //        //client.DownloadFileCompleted += (sender, e) =>
            //        //{
            //        //    UnpackFile(modelInfo);
            //        //    fileList = GetUnpackFile(modelInfo);
            //        //};
            //        client.DownloadFile(new Uri(abi.GetURL()), modelInfo.GetUnity3DFilePath());
            //        UnpackFile(modelInfo);
            //        return GetUnpackFile(modelInfo);
            //    }
            //}
        }
        private void UnpackFile(ModelInfo info)
        {
            using (Process p = new Process()) {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                //p.StartInfo.FileName = Settings.Config.Model.DisunityPath;
                p.StartInfo.Arguments = string.Format("-f texture2d,mesh extract {0}", info.GetUnity3DFilePath());
                p.Start();
                p.WaitForExit();
            }
        }
        private List<string> GetUnpackFile(ModelInfo info)
        {
            List<string> unpacked = new List<string>();
            DirectoryInfo di = new DirectoryInfo(info.GetModelDirectory());
            if (di.Exists) {
                foreach (FileInfo fi in di.GetFiles("*.*", SearchOption.AllDirectories)) {
                    string unpackedFileName = System.IO.Path.GetFileNameWithoutExtension(fi.FullName);
                    if (unpackedFileName.Contains(info.modelName) || info.modelName.Contains(unpackedFileName)) {
                        unpacked.Add(fi.FullName);
                    }
                }
            }
            return unpacked;
        }
        private async void InitModel(List<string> fileList)
        {
            string objFilePath = fileList.Find(o => o.EndsWith(".obj"));
            string ddsFilePath = fileList.Find(o => o.EndsWith(".dds") && (o.Contains("wpn.dss") == false));
            string wpnddsFilePath = fileList.Find(o => o.EndsWith("wpn.dds"));
            if (string.IsNullOrEmpty(objFilePath) || string.IsNullOrEmpty(ddsFilePath)) {
                LoadingMask.Visibility = Visibility.Collapsed;
                //Utility.ShowException("MODEL ERROR");
                return;
            }
            ModelImporter importer = new ModelImporter();
            Model3DGroup objModel = importer.Load(objFilePath);

            DDSImage image = await DDSReader.DDSReader.ReadImageAsync(ddsFilePath);
            BitmapSource bitmapSource = await image.Frames.First().ToBitmapSource();

            ImageBrush textureBrush = new ImageBrush(bitmapSource) { ViewportUnits = BrushMappingMode.Absolute, TileMode = TileMode.Tile };
            var material = new DiffuseMaterial(textureBrush);

            List<GeometryModel3D> splitedModelList = new List<GeometryModel3D>();
            if (objModel.Children.Count > 0) {
                GeometryModel3D model3d = objModel.Children[0] as GeometryModel3D;
                MeshGeometry3D mesh = model3d.Geometry as MeshGeometry3D;
                //MeshGeometry3D sortedMesh = GetSortedMesh(mesh);
                List<MeshGeometry3D> splitedMeshList = SplitMesh(mesh);
                foreach (MeshGeometry3D splitedMesh in splitedMeshList) {
                    GeometryModel3D splitModel = new GeometryModel3D();
                    splitModel.Geometry = splitedMesh;
                    splitModel.Material = material;
                    splitModel.BackMaterial = material;
                    splitedModelList.Add(splitModel);
                }
            }
            if (objModel.Children.Count > 1 && string.IsNullOrEmpty(wpnddsFilePath) == false) {
                DDSImage imageWpn = await DDSReader.DDSReader.ReadImageAsync(wpnddsFilePath);
                BitmapSource bitmapSourceWpn = await imageWpn.Frames.First().ToBitmapSource();

                ImageBrush textureBrushWpn = new ImageBrush(bitmapSourceWpn) { ViewportUnits = BrushMappingMode.Absolute, TileMode = TileMode.Tile };
                var materialWpn = new DiffuseMaterial(textureBrushWpn);

                GeometryModel3D model3d = objModel.Children[1] as GeometryModel3D;
                MeshGeometry3D mesh = model3d.Geometry as MeshGeometry3D;
                //MeshGeometry3D sortedMesh = GetSortedMesh(mesh);
                List<MeshGeometry3D> splitedMeshList = SplitMesh(mesh);
                foreach (MeshGeometry3D splitedMesh in splitedMeshList) {
                    GeometryModel3D splitModel = new GeometryModel3D();
                    splitModel.Geometry = splitedMesh;
                    splitModel.Material = materialWpn;
                    splitModel.BackMaterial = materialWpn;
                    splitedModelList.Add(splitModel);
                }
            }
            //group.Children = group.Children.OrderBy(o => (o as GeometryModel3D).Geometry.Bounds.Z);
            Model3DGroup group = new Model3DGroup();
            foreach (GeometryModel3D splitedModel in splitedModelList.OrderBy(o => o.Geometry.Bounds.Z)) {
                group.Children.Add(splitedModel);
            }
            model.Content = group;
            LoadingMask.Visibility = Visibility.Collapsed;
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        private BitmapSource BitmapToBitmapSource(System.Drawing.Bitmap bitmap)
        {
            IntPtr ptr = bitmap.GetHbitmap();
            BitmapSource result =
                System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    ptr, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            //release resource
            DeleteObject(ptr);

            return result;
        }
        private MeshGeometry3D GetSortedMesh(MeshGeometry3D mesh)
        {
            Dictionary<int, int> sortIndex = new Dictionary<int, int>();

            //sort by point-z
            Point3DCollection points = mesh.Positions;
            Point3DCollection sortedPoints = new Point3DCollection();
            Dictionary<int, Point3D> pointDict = new Dictionary<int, Point3D>();
            int i = 0;
            foreach (Point3D point in points) {
                pointDict.Add(i, point);
                i++;
            }
            pointDict = pointDict.OrderBy(o => o.Value.Z).ToDictionary(o => o.Key, o => o.Value);

            //get sort index & sorted Points
            i = 0;
            foreach (KeyValuePair<int, Point3D> kv in pointDict) {
                sortIndex.Add(i, kv.Key);
                sortedPoints.Add(kv.Value);
                i++;
            }

            //use sort index to sort texture
            PointCollection texture = mesh.TextureCoordinates;
            PointCollection sortedTexture = new PointCollection();
            foreach (KeyValuePair<int, int> kv in sortIndex) {
                sortedTexture.Add(texture[kv.Value]);
            }

            //sort triangle
            Int32Collection triangle = mesh.TriangleIndices;
            Int32Collection sortedTriangle = new Int32Collection();
            foreach (int tri in triangle) {
                sortedTriangle.Add(sortIndex.First(o => o.Value == tri).Key);
            }

            MeshGeometry3D sortedMesh = mesh.Clone();
            sortedMesh.Positions = sortedPoints;
            sortedMesh.TextureCoordinates = sortedTexture;
            sortedMesh.TriangleIndices = sortedTriangle;
            return sortedMesh;
        }
        private List<MeshGeometry3D> SplitMesh(MeshGeometry3D mesh)
        {
            Dictionary<double, List<int>> meshLayers = new Dictionary<double, List<int>>();
            int i = 0;
            foreach (Point3D point in mesh.Positions) {
                if (meshLayers.Keys.Contains(point.Z) == false) {
                    meshLayers.Add(point.Z, new List<int>());
                }
                meshLayers[point.Z].Add(i);
                i++;
            }

            meshLayers = meshLayers.OrderBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);

            List<MeshGeometry3D> splitedMeshList = new List<MeshGeometry3D>();
            int triCount = 0;
            foreach (KeyValuePair<double, List<int>> kv in meshLayers) {
                int j = 0;
                Dictionary<int, int> sortIndex = new Dictionary<int, int>();
                Point3DCollection sortedPoints = new Point3DCollection();
                PointCollection sortedTexture = new PointCollection();
                Int32Collection sortedTriangle = new Int32Collection();

                foreach (int index in kv.Value) {
                    sortIndex.Add(j, index);
                    sortedPoints.Add(mesh.Positions[index]);
                    sortedTexture.Add(mesh.TextureCoordinates[index]);
                    j++;
                }

                foreach (int tri in mesh.TriangleIndices) {
                    //var splitTri = sortIndex.DefaultIfEmpty(new KeyValuePair<int, int>(-1, -1)).FirstOrDefault(o => o.Value == tri);
                    if (sortIndex.Any(o => o.Value == tri)) {
                        sortedTriangle.Add(sortIndex.First(o => o.Value == tri).Key);
                    }
                }

                MeshGeometry3D partMesh = mesh.Clone();
                partMesh.Positions = sortedPoints;
                partMesh.TextureCoordinates = sortedTexture;
                partMesh.TriangleIndices = sortedTriangle;
                splitedMeshList.Add(partMesh);

                triCount += sortedTriangle.Count;
            }
            return splitedMeshList;
        }
    }
}
