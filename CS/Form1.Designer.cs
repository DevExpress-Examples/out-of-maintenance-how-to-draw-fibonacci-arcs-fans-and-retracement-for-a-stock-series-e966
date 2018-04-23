namespace FibonacciIndicators {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel1 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRetracements = new DevExpress.XtraEditors.SimpleButton();
            this.btnFans = new DevExpress.XtraEditors.SimpleButton();
            this.btnArcs = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRetracements);
            this.panelControl1.Controls.Add(this.btnFans);
            this.panelControl1.Controls.Add(this.btnArcs);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(722, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRetracements
            // 
            this.btnRetracements.Location = new System.Drawing.Point(320, 12);
            this.btnRetracements.Name = "btnRetracements";
            this.btnRetracements.Size = new System.Drawing.Size(138, 39);
            this.btnRetracements.TabIndex = 3;
            this.btnRetracements.Text = "Fibonacci Retracements ";
            this.btnRetracements.Click += new System.EventHandler(this.btnRetracements_Click);
            // 
            // btnFans
            // 
            this.btnFans.Location = new System.Drawing.Point(165, 12);
            this.btnFans.Name = "btnFans";
            this.btnFans.Size = new System.Drawing.Size(138, 39);
            this.btnFans.TabIndex = 2;
            this.btnFans.Text = "Fibonacci Fans";
            this.btnFans.Click += new System.EventHandler(this.btnFans_Click);
            // 
            // btnArcs
            // 
            this.btnArcs.Location = new System.Drawing.Point(12, 12);
            this.btnArcs.Name = "btnArcs";
            this.btnArcs.Size = new System.Drawing.Size(138, 39);
            this.btnArcs.TabIndex = 1;
            this.btnArcs.Text = "Fibonacci Arcs";
            this.btnArcs.Click += new System.EventHandler(this.btnArcs_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 63);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            stockSeriesLabel1.Visible = true;
            this.chartControl1.SeriesTemplate.Label = stockSeriesLabel1;
            this.chartControl1.SeriesTemplate.View = stockSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(722, 477);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 540);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnArcs;
        private DevExpress.XtraEditors.SimpleButton btnRetracements;
        private DevExpress.XtraEditors.SimpleButton btnFans;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

