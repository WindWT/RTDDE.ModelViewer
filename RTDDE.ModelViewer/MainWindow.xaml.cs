﻿using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

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
            new WindowResizer(this,
                new WindowBorder(BorderPosition.TopLeft, topLeft),
                new WindowBorder(BorderPosition.Top, top),
                new WindowBorder(BorderPosition.TopRight, topRight),
                new WindowBorder(BorderPosition.Right, right),
                new WindowBorder(BorderPosition.BottomRight, bottomRight),
                new WindowBorder(BorderPosition.Bottom, bottom),
                new WindowBorder(BorderPosition.BottomLeft, bottomLeft),
                new WindowBorder(BorderPosition.Left, left));
            //ChangeTab("Quest");
        }
        [Obsolete("use async and await instead")]
        public static readonly TaskScheduler UiTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

        private string LastTabName { get; set; }
        private void MenuButton_OnChecked(object sender, RoutedEventArgs e)
        {
            LastTabName = MenuButton.Content.ToString();
            MenuButton.Content = "MENU";
        }
        private void MenuButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            MenuButton.Content = string.IsNullOrEmpty(LastTabName) ? "MENU" : LastTabName;
        }
        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            Button tb = sender as Button;
            if (tb != null) {
                ChangeTab(tb.Name.Replace("MenuItem_", String.Empty));
            }
        }

        public async void ChangeTab(string tabName)
        {
            foreach (UserControl child in MainGrid.Children) {
                child.Visibility = Visibility.Collapsed;
            }
            var tab = await GetTabByName(tabName);
            if (tab != null) {
                tab.Visibility = Visibility.Visible;
                LastTabName = tab.GetType().Name;
            }
            MenuButton.IsChecked = false;
        }
        public async Task<UserControl> GetTabByName(string tabName)
        {
            foreach (UserControl child in MainGrid.Children) {
                if (string.Compare(child.GetType().Name, tabName, StringComparison.OrdinalIgnoreCase) == 0) {
                    return child;
                }
            }
            //该Tab尚未创建，尝试创建
            string tabFullName = string.Format("RTDDE.Executer.Func.{0}", tabName);
            var tabType = Type.GetType(tabFullName);
            if (tabType != null) {
                //long time loading, avoid UI lag
                Task<UserControl> taskCreate = Task.Factory.StartNew(
                    () => (UserControl)Activator.CreateInstance(tabType),
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.FromCurrentSynchronizationContext()
                    );
                UserControl tab = await taskCreate;
                if (tab != null) {
                    MainGrid.Children.Add(tab);
                    return tab;
                }
            }
            return null;
        }

        private void SB_ShowMenu_Completed(object sender, EventArgs e)
        {
            MenuMask.IsHitTestVisible = true;
        }

        private void SB_HideMenu_Completed(object sender, EventArgs e)
        {
            MenuMask.IsHitTestVisible = false;
        }

        private void MenuMask_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MenuButton.IsChecked = false;
        }

        //异常信息显示15秒之后消失。
        private DispatcherTimer _dispatcherTimer = null;
        private void StatusBarExceptionMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StatusBarExceptionMessage.Text)) {
                StatusBarExceptionMessage.Visibility = Visibility.Collapsed;
            }
            else {
                StatusBarExceptionMessage.Visibility = Visibility.Visible;
                _dispatcherTimer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 15) };
                EventHandler eh = null;
                eh = (a, b) =>
                {
                    _dispatcherTimer.Tick -= eh;
                    _dispatcherTimer.Stop();
                    StatusBarExceptionMessage.Text = String.Empty;
                };
                _dispatcherTimer.Tick += eh;
                _dispatcherTimer.Start();
            }
        }

        private void MoveBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MoveBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }

        private void MinimizedButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }

}
