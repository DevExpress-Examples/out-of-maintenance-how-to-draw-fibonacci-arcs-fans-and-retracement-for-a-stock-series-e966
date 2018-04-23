Imports Microsoft.VisualBasic
Imports System
Namespace FibonacciIndicators
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnRetracements = New DevExpress.XtraEditors.SimpleButton()
			Me.btnFans = New DevExpress.XtraEditors.SimpleButton()
			Me.btnArcs = New DevExpress.XtraEditors.SimpleButton()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnRetracements)
			Me.panelControl1.Controls.Add(Me.btnFans)
			Me.panelControl1.Controls.Add(Me.btnArcs)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(722, 63)
			Me.panelControl1.TabIndex = 0
			' 
			' btnRetracements
			' 
			Me.btnRetracements.Location = New System.Drawing.Point(320, 12)
			Me.btnRetracements.Name = "btnRetracements"
			Me.btnRetracements.Size = New System.Drawing.Size(138, 39)
			Me.btnRetracements.TabIndex = 3
			Me.btnRetracements.Text = "Fibonacci Retracements "
'			Me.btnRetracements.Click += New System.EventHandler(Me.btnRetracements_Click);
			' 
			' btnFans
			' 
			Me.btnFans.Location = New System.Drawing.Point(165, 12)
			Me.btnFans.Name = "btnFans"
			Me.btnFans.Size = New System.Drawing.Size(138, 39)
			Me.btnFans.TabIndex = 2
			Me.btnFans.Text = "Fibonacci Fans"
'			Me.btnFans.Click += New System.EventHandler(Me.btnFans_Click);
			' 
			' btnArcs
			' 
			Me.btnArcs.Location = New System.Drawing.Point(12, 12)
			Me.btnArcs.Name = "btnArcs"
			Me.btnArcs.Size = New System.Drawing.Size(138, 39)
			Me.btnArcs.TabIndex = 1
			Me.btnArcs.Text = "Fibonacci Arcs"
'			Me.btnArcs.Click += New System.EventHandler(Me.btnArcs_Click);
			' 
			' chartControl1
			' 
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 63)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			stockSeriesLabel1.Visible = True
			Me.chartControl1.SeriesTemplate.Label = stockSeriesLabel1
			Me.chartControl1.SeriesTemplate.View = stockSeriesView1
			Me.chartControl1.Size = New System.Drawing.Size(722, 477)
			Me.chartControl1.TabIndex = 1
			Me.chartControl1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(722, 540)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnArcs As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnRetracements As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnFans As DevExpress.XtraEditors.SimpleButton
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

