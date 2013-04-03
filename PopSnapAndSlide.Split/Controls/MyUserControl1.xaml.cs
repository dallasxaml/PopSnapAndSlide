using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PopSnapAndSlide.Split.Common;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PopSnapAndSlide.Split.Controls
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            var page = GetPage();
            if (page != null)
                page.StartLayoutUpdates(sender, e);
        }

        private void UserControl_Unloaded_1(object sender, RoutedEventArgs e)
        {
            var page = GetPage();
            if (page != null)
                page.StopLayoutUpdates(sender, e);
        }

        private LayoutAwarePage GetPage()
        {
            var ancestor = this.Parent as FrameworkElement;

            while (ancestor != null)
            {
                var container = ancestor as LayoutAwarePage;
                if (container != null)
                    return container;

                ancestor = ancestor.Parent as FrameworkElement;
            }

            return null;
        }
    }
}
