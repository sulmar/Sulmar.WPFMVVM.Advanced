using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.CustomControls
{
    [ContentProperty("MainContent")]
    public class MyControl : Control
    {
        public MyControl()
        {
            DefaultStyleKey = typeof(MyControl);
        }

        public object MainContent
        {
            get { return GetValue(MainContentProperty); }
            set { SetValue(MainContentProperty, value); }
        }

        public static readonly DependencyProperty MainContentProperty =
            DependencyProperty.Register("MainContent", typeof(object), typeof(MyControl), null);


        
    }
}
