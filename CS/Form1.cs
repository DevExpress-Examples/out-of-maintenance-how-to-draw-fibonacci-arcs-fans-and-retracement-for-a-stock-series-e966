using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace FibonacciIndicators {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region Initialization
        private void Form1_Load(object sender, EventArgs e) {
            // Create a series.
            Series series = new Series("Stock", ViewType.Stock);
            series.ArgumentScaleType = ScaleType.DateTime;

            // Populate the series with data.
            AddPoints(series);

            // Add it to the chart.
            this.chartControl1.Series.Add(series);

            // Adjust the chart's appearance.
            XYDiagram diagram = (XYDiagram)this.chartControl1.Diagram;
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            diagram.AxisX.Label.Staggered = true;
        }
        #endregion

        #region Providing Data
        private void AddPoints(Series series) {
            series.Points.AddRange(new SeriesPoint[] {
                new SeriesPoint(new DateTime(2007, 12, 24), new object[] {110.55, 112, 111.3, 111.65}),
                new SeriesPoint(new DateTime(2007, 12, 26), new object[] {110.9, 112.09, 110.9, 111.56}),
                new SeriesPoint(new DateTime(2007, 12, 27), new object[] {109.49, 111.3,  110.53, 109.6}),
                new SeriesPoint(new DateTime(2007, 12, 28), new object[] {109.108, 110.76, 110.76, 110.09}),
                new SeriesPoint(new DateTime(2007, 12, 31), new object[] {107.26, 110, 109.51, 108.1}),
                new SeriesPoint(new DateTime(2008, 1, 2), new object[] {104.17, 108.99, 108.99, 104.69}),
                new SeriesPoint(new DateTime(2008, 1, 3), new object[] {103.98, 105.57, 104.83, 104.9}),
                new SeriesPoint(new DateTime(2008, 1, 4), new object[] {100.48, 103.95, 103.95, 101.13}),
                new SeriesPoint(new DateTime(2008, 1, 7), new object[] {99.03, 101, 100.25, 100.05}),
                new SeriesPoint(new DateTime(2008, 1, 8), new object[] {97.17, 100.38, 100.05, 97.59}),
                new SeriesPoint(new DateTime(2008, 1, 9), new object[] {97.16, 99.15, 97.76, 98.31}),
                new SeriesPoint(new DateTime(2008, 1, 10), new object[] {97.15, 100.86, 97.39, 99.92}),
                new SeriesPoint(new DateTime(2008, 1, 11), new object[] {97.09, 99.46, 99.2, 97.67}),
                new SeriesPoint(new DateTime(2008, 1, 14), new object[] {101.33, 105.59, 105.01, 102.93}),
                new SeriesPoint(new DateTime(2008, 1, 15), new object[] {101.23, 104.04, 102.03, 101.83}),
                new SeriesPoint(new DateTime(2008, 1, 16), new object[] {100.14, 102.86, 100.14, 101.63}),
                new SeriesPoint(new DateTime(2008, 1, 17), new object[] {100.05, 103.45, 102, 101.1}),
                new SeriesPoint(new DateTime(2008, 1, 18), new object[] {102.5, 106.72, 106.72, 103.4}),
                new SeriesPoint(new DateTime(2008, 1, 22), new object[] {98.55, 103.09, 98.55, 101.22}),
                new SeriesPoint(new DateTime(2008, 1, 23), new object[] {98.5, 106.335, 99.63, 106.1}),
                new SeriesPoint(new DateTime(2008, 1, 24), new object[] {104.68, 107.51, 106.38, 106.91}),
                new SeriesPoint(new DateTime(2008, 1, 25), new object[] {104.1, 107.79, 107.79, 104.52}),
                new SeriesPoint(new DateTime(2008, 1, 28), new object[] {103.83, 105.77, 104.44, 104.98}),
                new SeriesPoint(new DateTime(2008, 1, 29), new object[] {104.6, 106.8, 105.5, 106.1}),
                new SeriesPoint(new DateTime(2008, 1, 30), new object[] {104.855, 107.65, 105.85, 105.65}),
                new SeriesPoint(new DateTime(2008, 1, 31), new object[] {103.7, 107.97, 104.21, 107.11})
             });
        }
        #endregion

        #region Processing Button_Click
        private void btnArcs_Click(object sender, EventArgs e) {
            AddIndicator(chartControl1.Series[0], FibonacciIndicatorKind.FibonacciArcs);
        }

        private void btnFans_Click(object sender, EventArgs e) {
            AddIndicator(chartControl1.Series[0], FibonacciIndicatorKind.FibonacciFans);
        }

        private void btnRetracements_Click(object sender, EventArgs e) {
            AddIndicator(chartControl1.Series[0], FibonacciIndicatorKind.FibonacciRetracement);
        }
        #endregion

        private void AddIndicator(Series ser, FibonacciIndicatorKind kind) {
            // Get a collection of indicators.
            IndicatorCollection indicators =
                ((StockSeriesView)ser.View).Indicators;
            
            // Clear it.
            indicators.Clear();

            // Add a new indicator to it.
            indicators.Add(CreateIndicator(kind, new DateTime(2007, 12, 27), 
                new DateTime(2008, 1, 17), ValueLevel.High));
        }

        private FibonacciIndicator CreateIndicator(FibonacciIndicatorKind kind,
            DateTime arg1, DateTime arg2, ValueLevel level) {

            // Create the Fibonacci Indicator of the specified kind.
            FibonacciIndicator fi = new FibonacciIndicator(kind);

            // Specify its start and end points.
            fi.Point1.Argument = arg1;
            fi.Point1.ValueLevel = level;
            fi.Point2.Argument = arg2;
            fi.Point2.ValueLevel = level;

            // Select the name.
            switch (fi.Kind) {
                case FibonacciIndicatorKind.FibonacciArcs: {
                        fi.Name = "Arcs";
                        break;
                    }
                case FibonacciIndicatorKind.FibonacciFans: {
                        fi.Name = "Fans";
                        break;
                    }
                case FibonacciIndicatorKind.FibonacciRetracement: {
                        fi.Name = "Retracement";
                        break;
                    }
            }

            // Make all its levels visible.
            fi.ShowLevel23_6 = true;
            fi.ShowLevel76_4 = true;
            fi.ShowLevel0 = true;
            fi.ShowLevel100 = true;
            fi.ShowAdditionalLevels = true;

            // Customize its appearance.
            fi.BaseLevelColor = Color.Green;
            fi.BaseLevelLineStyle.DashStyle = DashStyle.Dash;

            return fi;
        }
    }
}