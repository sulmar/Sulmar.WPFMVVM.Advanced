using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.AttachedProperties
{
    public class Ex : DependencyObject
    {
        public static readonly DependencyProperty SecurityIdProperty = DependencyProperty.RegisterAttached(
              "SecurityId", typeof(string), typeof(Ex), new PropertyMetadata(""));

        public static string GetSecurityId(DependencyObject d)
        {
            return (string)d.GetValue(SecurityIdProperty);
        }

        public static void SetSecurityId(DependencyObject d, string value)
        {
            d.SetValue(SecurityIdProperty, value);
        }
    }
}
