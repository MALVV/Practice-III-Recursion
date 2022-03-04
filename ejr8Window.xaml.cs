using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Tarea_04_03
{
    /// <summary>
    /// Lógica de interacción para ejr8Window.xaml
    /// </summary>
    public partial class ejr8Window : Window
    {
        public ejr8Window()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(ejr8Window_Loaded);
        }

        private int depth = 0;
        private int i = 0;
        void ejr8Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            canvas1.Children.Clear();

            CompositionTarget.Rendering += StartAnimation;
        }
        private void StartAnimation(object sender, EventArgs e)
        {
            i += 1;
            if (i % 40 == 0)
            {

                Point p1 = new Point(canvas1.Width / 2, 10);
                Point p2 = new Point(10, canvas1.Height - 10);
                Point p3 = new Point(canvas1.Width - 10, canvas1.Height - 10);
                DisplayTriangle(canvas1, p1, p2, p3, depth);
                depth += 1;
                if (depth > 5)
                {

                    CompositionTarget.Rendering -= StartAnimation;
                }
            }

        }


        private void DisplayTriangle(Canvas canvas, Point p1, Point p2, Point p3, int deep)
        {

            if (deep > 0)
            {
                Point p12 = midpoint(p1, p2);
                Point p23 = midpoint(p2, p3);
                Point p31 = midpoint(p3, p1);
                DisplayTriangle(canvas, p1, p12, p31, deep - 1);
                DisplayTriangle(canvas, p12, p2, p23, deep - 1);
                DisplayTriangle(canvas, p31, p23, p3, deep - 1);

            }
            else
            {
                DrawLine(p1, p2, canvas1);
                DrawLine(p1, p3, canvas1);
                DrawLine(p2, p3, canvas1);
                return;


            }
        }

        private void DrawLine(Point From, Point To, Canvas TargetCanvas)
        {
            Line line = new Line();
            line.Stroke = Brushes.Black;
            line.StrokeThickness = 1.0;
            line.X1 = From.X;
            line.Y1 = From.Y;
            line.X2 = To.X;
            line.Y2 = To.Y;
            TargetCanvas.Children.Add(line);
        }
        private static Point midpoint(Point p1, Point p2)
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
    }

}

