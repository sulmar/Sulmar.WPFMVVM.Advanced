using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.VisualDrawings
{
    public class MyVisualHost : FrameworkElement
    {
        private VisualCollection children;

        public MyVisualHost()
        {
            children = new VisualCollection(this);

            children.Add(CreateDrawingVisualRectangle());
            children.Add(CreateDrawingVisualLines());
        }

        private DrawingVisual CreateDrawingVisualLines()
        {
            DrawingVisual drawingVisual = new DrawingVisual();

            using (var dc = drawingVisual.RenderOpen())
            {
                dc.DrawLine(new Pen(Brushes.Black, 1), new Point(0, 0), new Point(400, 400));
                dc.DrawLine(new Pen(Brushes.Black, 1), new Point(0, 400), new Point(400, 0));
            }

            return drawingVisual;
        }

        // Create a DrawingVisual that contains a rectangle.
        private DrawingVisual CreateDrawingVisualRectangle()
        {
            DrawingVisual drawingVisual = new DrawingVisual();

            // Retrieve the DrawingContext in order to create new drawing content.
            DrawingContext drawingContext = drawingVisual.RenderOpen();

            // Create a rectangle and draw it in the DrawingContext.
            Rect rect = new Rect(new Point(160, 100), new Size(320, 80));
            drawingContext.DrawRectangle(Brushes.LightBlue, (Pen)null, rect);

            // Persist the drawing content.
            drawingContext.Close();

            return drawingVisual;
        }

        protected override int VisualChildrenCount
        {
            get { return children.Count; }
        }

        protected override Visual GetVisualChild(int index)
        {
            if (index < 0 || index >= children.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return children[index];
        }
    }
}
