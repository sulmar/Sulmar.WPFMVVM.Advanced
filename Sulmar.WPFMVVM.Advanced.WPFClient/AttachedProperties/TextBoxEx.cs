using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.AttachedProperties
{
    public class TextBoxEx : TextBox
    {
        public string SecurityId
        {
            get { return (string)GetValue(SecurityIdProperty); }
            set { SetValue(SecurityIdProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SecurityId.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecurityIdProperty =
            DependencyProperty.Register("SecurityId", typeof(string), typeof(TextBoxEx), new PropertyMetadata(""));

        public TextBoxEx()
        {
        }


    }
}
