using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace basketball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string state = "main", ring = "right";
        double t0, t, h, ballD, basketCenterX, basketCenterY, basketCenterZ, m, x0, y0, v0, h0, angleA, angleB;
        static int size;
        List<FinalTable> 
            finalTable = new List<FinalTable>();
        List<double>
            T = new List<double>(),
            X1 = new List<double>(), X2 = new List<double>(), X3 = new List<double>(),
            V1 = new List<double>(), V2 = new List<double>(), V3 = new List<double>(),
            A1 = new List<double>(), A2 = new List<double>(), A3 = new List<double>(), A4 = new List<double>(),
            B1 = new List<double>(), B2 = new List<double>(), B3 = new List<double>(), B4 = new List<double>(),
            C1 = new List<double>(), C2 = new List<double>(), C3 = new List<double>(), C4 = new List<double>(),
            D1 = new List<double>(), D2 = new List<double>(), D3 = new List<double>(), D4 = new List<double>(),
            E1 = new List<double>(), E2 = new List<double>(), E3 = new List<double>(), E4 = new List<double>(),
            F1 = new List<double>(), F2 = new List<double>(), F3 = new List<double>(), F4 = new List<double>();
        DrawingGroup
            trajectoryGraph = new DrawingGroup(),
            trajectoryGraph2 = new DrawingGroup(),
            positionGraph = new DrawingGroup();
        public MainWindow()
        {
            InitializeComponent();
            visibilitySetting(state);
            sizeSetting();
            positionGraphExecute(Convert.ToDouble(initialX.Text), Convert.ToDouble(initialY.Text));
            xPositionSlider.Value = 15 - Convert.ToDouble(initialX.Text);
            yPositionSlider.Value = Convert.ToDouble(initialY.Text);
        }
        public void calculation()
        {
            size = 0;
            t0 = 0;
            v0 = Convert.ToDouble(initialSpeed.Text);
            h0 = Convert.ToDouble(initialHeight.Text);
            x0 = Convert.ToDouble(initialX.Text);
            y0 = Convert.ToDouble(initialY.Text);
            angleA = Convert.ToDouble(initialAngleA.Text);
            angleB = Convert.ToDouble(initialAngleB.Text);
            switch (ballTypeValue.SelectedIndex)
            {
                case 0:
                    ballD = 0.2486;
                    m = 0.65;
                    break;
                case 1:
                    ballD = 0.2346;
                    m = 0.567;
                    break;
                case 2:
                    ballD = 0.226;
                    m = 0.5;
                    break;
                case 3:
                    ballD = 0.1846;
                    m = 0.33;
                    break;
            }
            switch (ringNum.SelectedIndex)
            {
                case 0:
                    ring = "right";
                    basketCenterX = 7.5;
                    basketCenterY = 26.425;
                    break;
                case 1:
                    ring = "left";
                    basketCenterX = 7.5;
                    basketCenterY = 1.575;
                    break;
            }
            h = Convert.ToDouble(stepValue.Text);
            basketCenterZ = Convert.ToDouble(basketHeight.Text);

            finalTable.Clear();
            T.Clear();
            X1.Clear(); X2.Clear(); X3.Clear();
            V1.Clear(); V2.Clear(); V3.Clear();
            A1.Clear(); A2.Clear(); A3.Clear(); A4.Clear();
            B1.Clear(); B2.Clear(); B3.Clear(); B4.Clear();
            C1.Clear(); C2.Clear(); C3.Clear(); C4.Clear();
            D1.Clear(); D2.Clear(); C3.Clear(); D4.Clear();
            E1.Clear(); E2.Clear(); E3.Clear(); E4.Clear();
            F1.Clear(); F2.Clear(); F3.Clear(); F4.Clear();

            T.Add(t0);
            X1.Add(x0);
            X2.Add(y0);
            X3.Add(h0);
            V1.Add(Math.Abs(v0) * Math.Sin(angleA * Math.PI / 180) * Math.Cos(angleB * Math.PI / 180));
            V2.Add(Math.Abs(v0) * Math.Sin(angleA * Math.PI / 180) * Math.Sin(angleB * Math.PI / 180));
            V3.Add(Math.Abs(v0) * Math.Cos(angleA * Math.PI / 180));

            A1.Add(h * f1(V1[0]));
            B1.Add(h * f2(V2[0]));
            C1.Add(h * f3(V3[0]));
            D1.Add(h * f4(V1[0], V2[0], V3[0]));
            E1.Add(h * f5(V1[0], V2[0], V3[0]));
            F1.Add(h * f6(V1[0], V2[0], V3[0]));

            A2.Add(h * f1(V1[0] + 0.5 * D1[0]));
            B2.Add(h * f2(V2[0] + 0.5 * E1[0]));
            C2.Add(h * f3(V3[0] + 0.5 * F1[0]));
            D2.Add(h * f4(V1[0] + 0.5 * D1[0], V2[0] + 0.5 * E1[0], V3[0] + 0.5 * F1[0]));
            E2.Add(h * f5(V1[0] + 0.5 * D1[0], V2[0] + 0.5 * E1[0], V3[0] + 0.5 * F1[0]));
            F2.Add(h * f6(V1[0] + 0.5 * D1[0], V2[0] + 0.5 * E1[0], V3[0] + 0.5 * F1[0]));

            A3.Add(h * f1(V1[0] + 0.5 * D2[0]));
            B3.Add(h * f2(V2[0] + 0.5 * E2[0]));
            C3.Add(h * f3(V3[0] + 0.5 * F2[0]));
            D3.Add(h * f4(V1[0] + 0.5 * D2[0], V2[0] + 0.5 * E2[0], V3[0] + 0.5 * F2[0]));
            E3.Add(h * f5(V1[0] + 0.5 * D2[0], V2[0] + 0.5 * E2[0], V3[0] + 0.5 * F2[0]));
            F3.Add(h * f6(V1[0] + 0.5 * D2[0], V2[0] + 0.5 * E2[0], V3[0] + 0.5 * F2[0]));

            A4.Add(h * f1(V1[0] + D3[0]));
            B4.Add(h * f2(V2[0] + E3[0]));
            C4.Add(h * f3(V3[0] + F3[0]));
            D4.Add(h * f4(V1[0] + D3[0], V2[0] + E3[0], V3[0] + F3[0]));
            E4.Add(h * f5(V1[0] + D3[0], V2[0] + E3[0], V3[0] + F3[0]));
            F4.Add(h * f6(V1[0] + D3[0], V2[0] + E3[0], V3[0] + F3[0]));

            finalTable.Add(new FinalTable(1, Math.Round(T[0], 3), Math.Round(X1[0], 3), Math.Round(X2[0], 3), Math.Round(X3[0], 3), Math.Round(Math.Abs(V1[0]), 3), Math.Round(Math.Abs(V2[0]), 3), Math.Round(Math.Abs(V3[0]), 3)));
            int i = 1;
            t = tMax();
            while (X3[i - 1] > 0)
            {
                T.Add(T[i - 1] + h);

                A1.Add(h * f1(V1[i - 1]));
                B1.Add(h * f2(V2[i - 1]));
                C1.Add(h * f3(V3[i - 1]));
                D1.Add(h * f4(V1[i - 1], V2[i - 1], V3[i - 1]));
                E1.Add(h * f5(V1[i - 1], V2[i - 1], V3[i - 1]));
                F1.Add(h * f6(V1[i - 1], V2[i - 1], V3[i - 1]));

                A2.Add(h * f1(V1[i - 1] + 0.5 * D1[i]));
                B2.Add(h * f2(V2[i - 1] + 0.5 * E1[i]));
                C2.Add(h * f3(V3[i - 1] + 0.5 * F1[i]));
                D2.Add(h * f4(V1[i - 1] + 0.5 * D1[i], V2[i - 1] + 0.5 * E1[i], V3[i - 1] + 0.5 * F1[i]));
                E2.Add(h * f5(V1[i - 1] + 0.5 * D1[i], V2[i - 1] + 0.5 * E1[i], V3[i - 1] + 0.5 * F1[i]));
                F2.Add(h * f6(V1[i - 1] + 0.5 * D1[i], V2[i - 1] + 0.5 * E1[i], V3[i - 1] + 0.5 * F1[i]));

                A3.Add(h * f1(V1[i - 1] + 0.5 * D2[i]));
                B3.Add(h * f2(V2[i - 1] + 0.5 * E2[i]));
                C3.Add(h * f3(V3[i - 1] + 0.5 * F2[i]));
                D3.Add(h * f4(V1[i - 1] + 0.5 * D2[i], V2[i - 1] + 0.5 * E2[i], V3[i - 1] + 0.5 * F2[i]));
                E3.Add(h * f5(V1[i - 1] + 0.5 * D2[i], V2[i - 1] + 0.5 * E2[i], V3[i - 1] + 0.5 * F2[i]));
                F3.Add(h * f6(V1[i - 1] + 0.5 * D2[i], V2[i - 1] + 0.5 * E2[i], V3[i - 1] + 0.5 * F2[i]));

                A4.Add(h * f1(V1[i - 1] + D3[i]));
                B4.Add(h * f2(V2[i - 1] + E3[i]));
                C4.Add(h * f3(V3[i - 1] + F3[i]));
                D4.Add(h * f4(V1[i - 1] + D3[i], V2[i - 1] + E3[i], V3[i - 1] + F3[i]));
                E4.Add(h * f5(V1[i - 1] + D3[i], V2[i - 1] + E3[i], V3[i - 1] + F3[i]));
                F4.Add(h * f6(V1[i - 1] + D3[i], V2[i - 1] + E3[i], V3[i - 1] + F3[i]));

                X1.Add(X1[i - 1] + (A1[i] + 2 * A2[i] + 2 * A3[i] + A4[i]) / 6);
                X2.Add(X2[i - 1] + (B1[i] + 2 * B2[i] + 2 * B3[i] + B4[i]) / 6);
                X3.Add(X3[i - 1] + (C1[i] + 2 * C2[i] + 2 * C3[i] + C4[i]) / 6);
                V1.Add(V1[i - 1] + (D1[i] + 2 * D2[i] + 2 * D3[i] + D4[i]) / 6);
                V2.Add(V2[i - 1] + (E1[i] + 2 * E2[i] + 2 * E3[i] + E4[i]) / 6);
                V3.Add(V3[i - 1] + (F1[i] + 2 * F2[i] + 2 * F3[i] + F4[i]) / 6);

                
                if (X3[i] <= 0)
                {
                    hitStatus.Text = "Не зафиксировано";
                    timeText.Text = "Общее время полета";
                    finalTable.Add(new FinalTable(i + 1, Math.Round(t, 3), Math.Round(x1(t), 3), Math.Round(x2(t), 3), Math.Round(x3(t), 3), 0, 0, 0));
                    break;
                }
                finalTable.Add(new FinalTable(i + 1, Math.Round(T[i], 3), Math.Round(X1[i], 3), Math.Round(X2[i], 3), Math.Round(X3[i], 3), Math.Round(Math.Abs(V1[i]), 3), Math.Round(Math.Abs(V2[i]), 3), Math.Round(Math.Abs(V3[i]), 3)));
                if ((Math.Pow(X1[i] - basketCenterX, 2) + Math.Pow(X2[i] - basketCenterY, 2) + Math.Pow(X3[i] - basketCenterZ, 2)  <= Math.Pow(0.46 / 2 - ballD / 2, 2)))
                {
                    hitStatus.Text = "Зафиксировано";
                    t = T[i];
                    finalTable.Add(new FinalTable(i + 2, Math.Round(T[i], 3), Math.Round(basketCenterX, 3), Math.Round(basketCenterY, 3), Math.Round(basketCenterZ, 3), Math.Round(Math.Abs(V1[i]), 3), Math.Round(Math.Abs(V2[i]), 3), Math.Round(Math.Abs(V3[i]), 3)));
                    timeText.Text = "Время до попадания";
                    size++;
                    break;
                }
                if (((X1[i - 1] > basketCenterX && basketCenterX >= X1[i]) || (X1[i - 1] < basketCenterX && basketCenterX <= X1[i])) && X3[i - 1] > basketCenterZ && basketCenterZ >= X3[i] && ((X2[i - 1] < basketCenterY && basketCenterY <= X2[i] && ring == "right") || (X2[i - 1] > basketCenterY && basketCenterY >= X2[i] && ring == "left")))
                {
                    hitStatus.Text = "Зафиксировано";
                    t = T[i];
                    finalTable.Add(new FinalTable(i + 2, Math.Round(T[i], 3), Math.Round(basketCenterX, 3), Math.Round(basketCenterY, 3), Math.Round(basketCenterZ, 3), Math.Round(Math.Abs(V1[i]), 3), Math.Round(Math.Abs(V2[i]), 3), Math.Round(Math.Abs(V3[i]), 3)));
                    timeText.Text = "Время до попадания";
                    size++;
                    break;
                }
                i++; size++;
            }
            maxHeightValue.Text = "H = " + Convert.ToString(Math.Round(hMax(), 2)) + " м";
            distanceValue.Text = "L = " + Convert.ToString(Math.Round(lMax(), 2)) + " м";
            timeValue.Text = "T = " + Convert.ToString(Math.Round(t, 2)) + "  c";

            graphExecute();
            dataTable.ItemsSource = finalTable;
        }
        public double f1(double v1)
        {
            return v1;
        }
        public double f2(double v2)
        {
            return v2;
        }
        public double f3(double v3)
        {
            return v3;
        }
        public double f4(double v1, double v2, double v3)
        {
            return (-1 * (0.47 * 1.2041 * Math.PI * ballD * ballD) / (8 * m)) * Math.Sqrt(v1 * v1 + v2 * v2 + v3 * v3) * v1;
        }
        public double f5(double v1, double v2, double v3)
        {
            return (-1 * (0.47 * 1.2041 * Math.PI * ballD * ballD) / (8 * m)) * Math.Sqrt(v1 * v1 + v2 * v2 + v3 * v3) * v2;
        }
        public double f6(double v1, double v2, double v3)
        {
            return (-1 * (0.283 * Math.PI * ballD * ballD) / (8 * m)) * Math.Sqrt(v1 * v1 + v2 * v2 + v3 * v3) * v3 - 9.81;
        }
        public double hMax()
        {
            return h0 + ((v0 * v0 * Math.Pow(Math.Cos(angleA * Math.PI / 180), 2)) / 19.62);
        }
        public double lMax()
        {
            return v0 * Math.Sin(angleA * Math.PI / 180) * tMax();
        }
        public double tMax()
        {
            return (v0 * Math.Cos(angleA * Math.PI / 180) + Math.Sqrt(Math.Pow(v0 * Math.Cos(angleA * Math.PI / 180), 2) + (2 * 9.81 * h0))) / 9.81;
        }
        public double x1(double t)
        {
            return (x0 + v0 * Math.Sin(angleA * Math.PI / 180) * Math.Cos(angleB * Math.PI / 180) * t);
        }
        public double x2(double t)
        {
            return (y0 + v0 * Math.Sin(angleA * Math.PI / 180) * Math.Sin(angleB * Math.PI / 180) * t);
        }
        public double x3(double t)
        {
            return (h0 + v0 * Math.Cos(angleA * Math.PI / 180) * t - (9.81 * t * t) / 2);
        }
        void positionGraphExecute(double point1, double point2)
        {
            positionGraph.Children.Clear();
            background(positionGraph);
            lines(positionGraph);
            fieldDraw(positionGraph, Color.FromRgb(84, 85, 116));
            positiongraphPoint(point1, point2);
            positionGraphImage.Source = new DrawingImage(positionGraph);
        }
        void graphExecute()
        {
            trajectoryGraph.Children.Clear();
            trajectoryGraph2.Children.Clear();
            background(trajectoryGraph);
            background(trajectoryGraph2);

            if (linesCheckBox.IsChecked == true)
            {
                lines(trajectoryGraph);
                lines(trajectoryGraph2);
            }
            basketDraw(trajectoryGraph, Color.FromRgb(84, 85, 116));
            graphZY(X2, X3, 0, 28, 15, trajectoryGraph, Color.FromRgb(216, 135, 20)); 
            fieldDraw(trajectoryGraph2, Color.FromRgb(84, 85, 116));
            graphXY(X2, X1, 28, 15, trajectoryGraph2, Color.FromRgb(216, 135, 20));
            trajectoryGraphImage.Source = new DrawingImage(trajectoryGraph);
            trajectoryGraphImage2.Source = new DrawingImage(trajectoryGraph2);
        }
        public void background(DrawingGroup output)
        {
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            RectangleGeometry rectGeometry = new RectangleGeometry(new Rect(0, 0, 28.0 / 15, 1));
            geometryDrawing.Geometry = rectGeometry;
            geometryDrawing.Pen = new Pen(new SolidColorBrush(Color.FromRgb(41, 41, 41)), 0.005);
            geometryDrawing.Brush = Brushes.Transparent;
            output.Children.Add(geometryDrawing);
        }
        public void lines(DrawingGroup output)
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            for (int i = 1; i < 15; i++)
            {
                LineGeometry line = new LineGeometry(new Point(0, i * 1.0 / 15), new Point(28.0 / 15, i * 1.0 / 15));
                geometryGroup.Children.Add(line);
            }
            for(int i=1; i < 28; i++)
            {
                LineGeometry line1 = new LineGeometry(new Point(i * 1.0 / 15, 0), new Point(i * 1.0 / 15, 1));
                geometryGroup.Children.Add(line1);
            }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Pen = new Pen(Brushes.LightGray, 0.0015);
            output.Children.Add(geometryDrawing);
        }
        public void graphZY(List<double> horizontal, List<double> vertical, double horizontal0, double maxHorizontal, double maxVertical, DrawingGroup output, Color color)
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            for (int i = 0; i <= size; i++)
                if (vertical[i] >= 0)
                {
                    EllipseGeometry ellips = new EllipseGeometry(new Point(28.0 / 15 * (horizontal[i] - horizontal0) / maxHorizontal, 1 - (vertical[i] / maxVertical)), ballD / 300.0, ballD / 300.0);
                    geometryGroup.Children.Add(ellips);
                }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Pen = new Pen(new SolidColorBrush(color), 0.016);
            geometryDrawing.Geometry = geometryGroup;
            output.Children.Add(geometryDrawing);
        }
        public void graphXY(List<double> horizontal, List<double> vertical, double maxHorizontal, double maxVertical, DrawingGroup output, Color color)
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            for (int i = 0; i <= size; i++)
                if (vertical[i] >= 0)
                {
                    EllipseGeometry ellips = new EllipseGeometry(new Point(28.0 / 15 * horizontal[i] / maxHorizontal, vertical[i] / maxVertical), ballD / 300.0, ballD / 300.0);
                    geometryGroup.Children.Add(ellips);
                }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Pen = new Pen(new SolidColorBrush(color), 0.016);
            geometryDrawing.Geometry = geometryGroup;
            output.Children.Add(geometryDrawing);
        }
        void positionGraphField()
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            double[] 
                ellipsX1 = { 14.0, 5.8, 22.2 },
                rectangleX1 = { 0, 22.2 };
            double ellipsY1 = 0.5, ellipsR = 1.8 / 15, rectangleHeight = 4.9 / 15, rectangleWidth = 5.8 / 15, rectangleY1 = 5.05;
            for(int i = 0; i < 3; i++)
            {
                EllipseGeometry ellips = new EllipseGeometry(new Point(ellipsX1[i] / 15, ellipsY1), ellipsR, ellipsR);
                geometryGroup.Children.Add(ellips);
                if(i > 0)
                {
                    RectangleGeometry rectGeometry = new RectangleGeometry(new Rect(rectangleX1[i - 1], rectangleY1 / 15, rectangleWidth, rectangleHeight));
                    geometryGroup.Children.Add(rectGeometry);
                }
            }
            LineGeometry newLine = new LineGeometry(new Point(14.0 / 15, 0), new Point(14.0 / 15, 1));
            geometryGroup.Children.Add(newLine);
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Pen = new Pen(new SolidColorBrush(Color.FromRgb(84, 85, 116)), 0.005);
            positionGraph.Children.Add(geometryDrawing);
        }
        void positiongraphPoint(double point2, double point1)
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            EllipseGeometry ellips = new EllipseGeometry(new Point(point1 / 15.0,  point2 / 15.0), 0.008, 0.008);
            geometryGroup.Children.Add(ellips);
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Pen = new Pen(new SolidColorBrush(Color.FromRgb(174, 60, 60)), 0.016);
            geometryDrawing.Geometry = geometryGroup;
            positionGraph.Children.Add(geometryDrawing);
        }
        public void fieldDraw(DrawingGroup output, Color color)
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            double[] 
                x1 = { 14, 1.2, 0.68, 0.68, 0.68, 26.8, 27.32, 27.32, 27.32 },
                y1 = { 0, 6.6, 7.4, 7.4, 7.6, 6.6, 7.4, 7.4, 7.6 },
                x2 = { 14, 1.2, 0.68, 1.2, 1.2, 26.8, 27.32, 26.8, 26.8 },
                y2 = { 15, 8.4, 7.6, 7.25, 7.75, 8.4, 7.6, 7.25, 7.75 },
                ellipsX1 = { 14, 5.8, 22.2, 1.63, 26.37 },
                ellipsR = { 1.8, 1.8, 1.8, 0.23, 0.23 },
                rectangleX1 = { 0, 22.2, 1.2, 26.6 },
                rectangleY1 = { 5.05, 5.05, 7.4, 7.4 },
                rectangleWidth = { 5.8, 5.8, 0.2, 0.2 },
                rectangleHeight = { 4.9, 4.9, 0.2, 0.2 };
            double ellipsY1 = 0.5;
            for (int i = 0; i < 9; i++)
            {
                LineGeometry newLine = new LineGeometry(new Point(x1[i] / 15.0, y1[i] / 15.0), new Point(x2[i] / 15.0, y2[i] / 15.0));
                geometryGroup.Children.Add(newLine);
                if (i >= 4)
                {
                    EllipseGeometry ellips = new EllipseGeometry(new Point(ellipsX1[i - 4] / 15.0, ellipsY1), ellipsR[i - 4] / 15.0, ellipsR[i - 4] / 15.0);
                    geometryGroup.Children.Add(ellips);
                }
                if (i >= 5)
                {
                    RectangleGeometry rectGeometry = new RectangleGeometry(new Rect(rectangleX1[i - 5] / 15.0, rectangleY1[i - 5] / 15.0, rectangleWidth[i - 5] / 15.0, rectangleHeight[i - 5] / 15.0));
                    geometryGroup.Children.Add(rectGeometry);
                }
            }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Pen = new Pen(new SolidColorBrush(color), 0.005);
            output.Children.Add(geometryDrawing);
        }
        public void basketDraw(DrawingGroup output, Color color)
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            double[]
                x1 = { 26.14, 27.32, 26.8, 27.32, 27.32, 1.2, 0.68, 1.2, 0.68, 0.68 },
                y1 = { 11.95, 11.75, 11.05, 11.95, 11.75, 11.95, 11.75, 11.05, 11.95, 11.75 },
                x2 = { 26.8, 27.32, 26.8, 26.8, 26.8, 1.86, 0.68, 1.2, 1.2, 1.2 },
                y2 = { 11.95, 15, 12.1, 11.65, 11.45, 11.95, 15, 12.1, 11.65, 11.45 };
            for(int i = 0; i < 10; i++)
            {
                LineGeometry newLine = new LineGeometry(new Point(x1[i] / 15, y1[i] / 15), new Point(x2[i] / 15, y2[i] / 15));
                geometryGroup.Children.Add(newLine);
            }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Pen = new Pen(new SolidColorBrush(color), 0.005);
            output.Children.Add(geometryDrawing);
        }

        public double max(double[] arr)
        {
            double max = arr[0];
            foreach (double a in arr)
                if (a > max)
                    max = a;
            return max;
        }

        private void yPositionSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            initialY.Text = Convert.ToString(yPositionSlider.Value);
            positionGraphExecute(Convert.ToDouble(initialX.Text), Convert.ToDouble(initialY.Text));
        }

        private void xPositionSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            initialX.Text = Convert.ToString(15 - xPositionSlider.Value);
            positionGraphExecute(Convert.ToDouble(initialX.Text), Convert.ToDouble(initialY.Text));
        }
        private void initialY_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (yPositionSlider != null && initialY.Text != "")
                yPositionSlider.Value = Convert.ToDouble(initialY.Text);
        }

        private void initialX_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (xPositionSlider != null && initialX.Text != "")
                xPositionSlider.Value = 15 - Convert.ToDouble(initialX.Text);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sizeSetting();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            sizeSetting();
        }
        //настройка размеров элементов на страницах
        public void sizeSetting()
        {
            if (this.ActualWidth > 0)
            {
                //панель навигации
                mainStackPanel.Width = modelingStackPanel.Width = detailsStackPanel.Width = navigationGrid.ActualWidth - 20;
                //главная
                mainPageStackPanel.Width = mainPageGrid.ActualWidth - 40;
                function1.Width = function2.Width = function3.Width = (mainPageStackPanel.ActualWidth - 60) / 3;
                if (function1.ActualWidth > function1.ActualHeight)
                {
                    function1Image.Height = function1.ActualHeight * 0.4;
                    function2Image.Height = function2.ActualHeight * 0.4;
                    function3Image.Height = function3.ActualHeight * 0.4;
                }
                else if (function1.ActualWidth <= function1.ActualHeight)
                {
                    function1Image.Width = function1.ActualWidth * 0.4;
                    function2Image.Width = function2.ActualWidth * 0.4;
                    function3Image.Width = function3.ActualWidth * 0.4;
                }
                //моделирование
                modelingPageStackPanel.Width = modelingPageGrid.ActualWidth - 40;
                variablesCard.Width = parametersCard.Width = (modelingPageStackPanel.ActualWidth - 40) / 2;
                calculatetButton.Width = modelingPageStackPanel.ActualWidth - 20;
                resultCard.Height = dataTable.Height + 100;
                function1Text.Width = function2Text.Width = function3Text.Width = function1.ActualWidth - 40;
                BDRounded.Width = dataTable.ActualWidth + 1;
                BDRounded.Height = dataTable.ActualHeight + 1;
                double[] functionsTextHeights = { function1Text.ActualHeight, function2Text.ActualHeight, function3Text.ActualHeight };
                function1Text.Height = function2Text.Height = function3Text.Height = max(functionsTextHeights);
                double[] resultsTextHeights = { successText.ActualHeight, maxHeighText.ActualHeight, distanceText.ActualHeight, timeText.ActualHeight };
                successText.Height = maxHeighText.Height = distanceText.Height = timeText.Height = max(resultsTextHeights);
                double[] resultValuesHeights = { hitStatus.ActualHeight, maxHeightValue.ActualHeight, distanceValue.ActualHeight, timeValue.ActualHeight };
                hitStatus.Height = maxHeightValue.Height = distanceValue.Height = timeValue.Height = max(resultValuesHeights);
                successCard.Height = successText.ActualHeight + hitStatus.ActualHeight + 90;
                maxHeightCard.Height = maxHeighText.ActualHeight + maxHeightValue.ActualHeight + 90;
                distanceCard.Height = distanceText.ActualHeight + distanceValue.ActualHeight + 90;
                timeCard.Height = timeText.ActualHeight + timeValue.ActualHeight + 90;
                positionGrid.Height = positionCard.ActualHeight - positionText.ActualHeight;
                xPositionSlider.Height = positionGraphImage.ActualHeight;
                yPositionSlider.Width = positionGraphImage.ActualWidth;
                //подробности
                detailsPageStackPanel.Width = detailsPageGrid.ActualWidth - 40;
                modelDescriptionCard.Width = (detailsPageStackPanel.ActualWidth - 60) / 3;
                modelDescriptionCard.Height = modelDescriptionText1.ActualHeight + modelDescriptionText2.ActualHeight + 100;
                modelDescriptionText1.Width = modelDescriptionText2.Width = modelDescriptionCard.ActualWidth - 80;
                basketSizeCard.Width = backboardSizeCard.Width = fieldCard.Width = fieldSizeCard.Width = ringSizeCard.Width = (detailsPageStackPanel.ActualWidth - 40) / 2;
                hitDiscriptionText.Width = hitDiscription.ActualWidth - 80;
                hitDiscription.Height = hitDiscriptionText.ActualHeight + 100;
                backboardSizeCard.Height = backboardSizeImage.ActualHeight + 120;
                ringSizeCard.Height = basketSizeCard.ActualHeight - backboardSizeCard.ActualHeight - 20;
                hitCardsStackPanel.Orientation = Orientation.Vertical;
                hitCard7.Width = hitCard6.Width = hitCard5.Width = hitCard3.Width = (detailsPageStackPanel.ActualWidth - 40) / 2;
                hit7Image.Width = hit6Image.Width = hit5Image.Width = hit3Image.Width = hitCard7.ActualWidth - 150;
                hitCard7.Height = hitCard6.Height = hitCard5.Height = hitCard3.Height = hit7Image.ActualHeight + 80;
                nonSignificantPhenomenaCard.Width = significantPhenomenaCard.Width = (detailsPageStackPanel.ActualWidth - 40) / 2;
                if (nonSignificantPhenomenaText2.ActualHeight >= significantPhenomenaText2.ActualHeight)
                    nonSignificantPhenomenaCard.Height = significantPhenomenaCard.Height = nonSignificantPhenomenaText2.ActualHeight + 100;
                else if (nonSignificantPhenomenaText2.ActualHeight < significantPhenomenaText2.ActualHeight)
                    nonSignificantPhenomenaCard.Height = significantPhenomenaCard.Height = significantPhenomenaText2.ActualHeight + 100;
                if (this.ActualWidth < 1300)
                {
                    ballsStackPanel.Orientation = Orientation.Vertical;
                    ball7Card.Height = ball6Card.Height = ball5Card.Height = ball3Card.Height = (modelDescriptionCard.ActualHeight - 20) / 2;
                    ball7Card.Width = ball6Card.Width = ball5Card.Width = ball3Card.Width = ((detailsPageStackPanel.ActualWidth - 60) / 3 * 2) / 2;
                    if (ball7Card.ActualHeight > 70)
                        ball7Image.MaxHeight = ball6Image.MaxHeight = ball5Image.MaxHeight = ball3Image.MaxHeight = ball7Card.ActualHeight - 70;
                    ball7Image.Margin = ball6Image.Margin = ball5Image.Margin = ball3Image.Margin = new Thickness(0, (ball7Card.ActualHeight - ball7Image.ActualHeight - 40) / 2, 0, 0);
                    valuesCardsStackPanel.Orientation = Orientation.Vertical;
                    distanceCard.Width = timeCard.Width = maxHeightCard.Width = successCard.Width = (modelingPageStackPanel.ActualWidth - 40) / 2;
                }
                else if (this.ActualWidth >= 1300)
                {
                    ballsStackPanel.Orientation = Orientation.Horizontal;
                    ball7Card.Height = ball6Card.Height = ball5Card.Height = ball3Card.Height = modelDescriptionCard.ActualHeight;
                    ball7Card.Width = ball6Card.Width = ball5Card.Width = ball3Card.Width = ((detailsPageStackPanel.ActualWidth - 60) / 3 * 2 - 40) / 4;
                    ball7Image.Margin = ball6Image.Margin = ball5Image.Margin = ball3Image.Margin = new Thickness(0, (ball7Card.ActualHeight - ball7Image.ActualHeight - 30) / 2, 0, 0);
                    ball7Image.Width = ball6Image.Width = ball5Image.Width = ball3Image.Width = ball7Card.ActualWidth - 70;
                    if(ball7Card.ActualHeight > 70)
                        ball7Image.MaxHeight = ball6Image.MaxHeight = ball5Image.MaxHeight = ball3Image.MaxHeight = ball7Card.ActualHeight - 70;
                    valuesCardsStackPanel.Orientation = Orientation.Horizontal;
                    distanceCard.Width = timeCard.Width = maxHeightCard.Width = successCard.Width = (modelingPageStackPanel.ActualWidth - 80) / 4;
                }
                test1.Text = Convert.ToString("");
                test2.Text = Convert.ToString("");
                test3.Text = Convert.ToString("");
            }
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            sizeSetting();
        }

        private void function1_MouseEnter(object sender, MouseEventArgs e)
        {
            function1.Height = function1.ActualHeight + 5;
            function1.Width = function1.ActualWidth + 5;
            function1Image.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/basket.png"));
        }

        private void function1_MouseLeave(object sender, MouseEventArgs e)
        {
            function1.Height = function1.ActualHeight - 5;
            function1.Width = function1.ActualWidth - 5;
            function1Image.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/basketGray.png"));
        }

        private void function2_MouseEnter(object sender, MouseEventArgs e)
        {
            function2.Height = function2.ActualHeight + 5;
            function2.Width = function2.ActualWidth + 5;
            function2Image.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/size.png"));
        }

        private void function2_MouseLeave(object sender, MouseEventArgs e)
        {
            function2.Height = function2.ActualHeight - 5;
            function2.Width = function2.ActualWidth - 5;
            function2Image.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/sizeGray.png"));
        }

        private void function3_MouseEnter(object sender, MouseEventArgs e)
        {
            function3.Height = function3.ActualHeight + 5;
            function3.Width = function3.ActualWidth + 5;
            function3Image.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/trajectory.png"));
        }

        private void function3_MouseLeave(object sender, MouseEventArgs e)
        {
            function3.Height = function3.ActualHeight - 5;
            function3.Width = function3.ActualWidth - 5;
            function3Image.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/trajectoryGray.png"));
        }
        public void visibilitySetting(string state)
        {
            if (state == "main")
            {
                mainPageGrid.Visibility = Visibility.Visible;
                modelingPageGrid.Visibility = Visibility.Hidden;
                detailsPageGrid.Visibility = Visibility.Hidden;
                mainTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(1, 1, 1));
                detailsTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                modelingTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                mainImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/infoSelected.png"));
                modelingImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/calculateOrdinary.png"));
                detailsImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/detailsOrdinary.png"));
            }
            else if (state == "modeling")
            {
                mainPageGrid.Visibility = Visibility.Hidden;
                modelingPageGrid.Visibility = Visibility.Visible;
                detailsPageGrid.Visibility = Visibility.Hidden;
                modelingTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(1, 1, 1));
                detailsTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                mainTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                mainImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/infoOrdinary.png"));
                modelingImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/calculateSelected.png"));
                detailsImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/detailsOrdinary.png"));
            }
            else if (state == "details")
            {
                mainPageGrid.Visibility = Visibility.Hidden;
                modelingPageGrid.Visibility = Visibility.Hidden;
                detailsPageGrid.Visibility = Visibility.Visible;
                detailsTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(1, 1, 1));
                modelingTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                mainTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                mainImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/infoOrdinary.png"));
                modelingImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/calculateOrdinary.png"));
                detailsImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/detailsSelected.png"));
            }
        }

        private void mainButton_Click(object sender, RoutedEventArgs e)
        {
            state = "main";
            visibilitySetting(state);
        }

        private void modelingButton_Click(object sender, RoutedEventArgs e)
        {
            state = "modeling";
            visibilitySetting(state);
        }

        private void moreButton_Click(object sender, RoutedEventArgs e)
        {
            state = "details";
            visibilitySetting(state);
        }

        public void mainButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (state != "main")
            {
                mainTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(41, 41, 41));
                mainImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/infoMouseOver.png"));
            }
        }

        public void mainButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (state != "main")
            {
                mainTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                mainImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/infoOrdinary.png"));
            }
        }

        public void modelingButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (state != "modeling")
            {
                modelingTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(41, 41, 41));
                modelingImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/calculateMouseOver.png"));
            }
        }

        public void modelingButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (state != "modeling")
            {
                modelingTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                modelingImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/calculateOrdinary.png"));
            }
        }

        public void moreButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (state != "details")
            {
                detailsTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(41, 41, 41));
                detailsImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/detailsMouseOver.png"));
            }
        }

        public void moreButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (state != "details")
            {
                detailsTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(163, 162, 158));
                detailsImage.Source = new BitmapImage(new Uri("pack://application:,,,/basketball;component/Resources/detailsOrdinary.png"));
            }
        }

        private void calculatetButton_Click(object sender, RoutedEventArgs e)
        {
            calculation();
            if (resultStackPanel.Visibility != Visibility.Visible)
            {
                resultStackPanel.Visibility = Visibility.Visible;
                valuesStackPanel.Visibility = Visibility.Visible;
                trajectoryStackPanel.Visibility = Visibility.Visible;
            }
        }

        private void dataTable_Loaded(object sender, RoutedEventArgs e)
        {
            dataTable.ItemsSource = finalTable;
        }

        private void dataTable_MouseUp(object sender, MouseButtonEventArgs e)
        {
            FinalTable path = dataTable.SelectedItem as FinalTable;
            message(
                "Информация о точке:\n\nНомер точки:\nМомент времени:\nX:\nY:\nZ:\nПроекция скорости на ось X:\nПроекция скорости на ось Y:\nПроекция скорости на ось Z:",
                Convert.ToString(path.i) + "\n" + Convert.ToString(path.t) + "\n" + Convert.ToString(path.X) + "\n" + Convert.ToString(path.Y) + "\n" + Convert.ToString(path.Z) + "\n" + Convert.ToString(path.Vx) + "\n" + Convert.ToString(path.Vy) + "\n" + Convert.ToString(path.Vz));
        }
        public void message(string text, string text2)
        {
            message msg = new message();
            msg.showMessage(text, text2);
            msg.ShowDialog();
        }
    }
}
