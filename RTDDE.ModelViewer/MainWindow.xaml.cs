using FreeImageAPI;
using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RTDDE.ModelViewer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init3DModel();
        }
        private void Init3DModel()
        {
            ModelImporter importer = new ModelImporter();
            Model3DGroup group = importer.Load(@"D:\work\RTD\RTDDE.ModelViewer\RTDDE.ModelViewer\bin\Release\e06_wz_fat_h_01.obj");

            FIBITMAP fiBitmap = FreeImage.Load(FREE_IMAGE_FORMAT.FIF_DDS, @"D:\work\RTD\RTDDE.ModelViewer\RTDDE.ModelViewer\bin\Release\330_e06_wz_fat_h_01.dds", FREE_IMAGE_LOAD_FLAGS.DEFAULT);
            Bitmap b = FreeImage.GetBitmap(fiBitmap);
            BitmapSource bitmapSource = BitmapToBitmapSource(b);
            
            ImageBrush textureBrush = new ImageBrush(bitmapSource) { ViewportUnits = BrushMappingMode.Absolute, TileMode = TileMode.Tile };
            var material = new DiffuseMaterial(textureBrush);

            foreach (GeometryModel3D model3d in group.Children)
            {
                model3d.Material = material;
                model3d.BackMaterial = material;
            }

            viewer.Children.Add(new DefaultLights());
            model.Content = group;
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
    }

}
