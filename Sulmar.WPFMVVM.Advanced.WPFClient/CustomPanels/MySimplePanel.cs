using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.CustomPanels
{
    public class MySimplePanel : Panel
    {
        // Make the panel as big as the biggest element
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (UIElement element in Children)
            {
                //Give Infinite size as the avaiable size for all the children
                element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            }

            return base.MeasureOverride(availableSize);
        }

        // Arrange the child elements to their final position
        protected override Size ArrangeOverride(Size finalSize)
        {
            double x = 0;
            double y = 0;

            foreach (UIElement element in Children)
            {
                Point actualChildPoint = new Point(x, y);
                
                x += element.DesiredSize.Width;
                y += element.DesiredSize.Height;

                element.Arrange(new Rect(actualChildPoint.X, actualChildPoint.Y, element.DesiredSize.Width, element.DesiredSize.Height));

            }

            return finalSize;
        }
    }
}
