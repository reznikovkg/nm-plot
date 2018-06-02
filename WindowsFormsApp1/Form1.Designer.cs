using System.Windows.Controls;
using OxyPlot.WindowsForms;

namespace nmplot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.initial_param_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.initial_param_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxFunction = new System.Windows.Forms.CheckBox();
            this.checkBoxSpline = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxPoints = new System.Windows.Forms.CheckBox();
            this.checkBoxPolynom = new System.Windows.Forms.CheckBox();
            this.checkBoxShowHide = new System.Windows.Forms.CheckBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonSetTBLR = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.chart_plot)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_plot
            // 
            chartArea1.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.Name = "ChartArea1";
            this.chart_plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_plot.Legends.Add(legend1);
            this.chart_plot.Location = new System.Drawing.Point(12, 35);
            this.chart_plot.Name = "chart_plot";
            this.chart_plot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.LegendText = "Function";
            series1.Name = "Function";
            series1.ShadowColor = System.Drawing.SystemColors.ControlDarkDark;
            series1.ShadowOffset = 1;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.LegendText = "Points";
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.MarkerBorderWidth = 5;
            series2.MarkerColor = System.Drawing.Color.WhiteSmoke;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star6;
            series2.Name = "Points";
            series2.ShadowOffset = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Spline";
            series3.Name = "Spline";
            series3.ShadowColor = System.Drawing.SystemColors.ControlDarkDark;
            series3.ShadowOffset = 1;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Lime;
            series4.Legend = "Legend1";
            series4.Name = "Polynom";
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.ShadowOffset = 1;
            this.chart_plot.Series.Add(series1);
            this.chart_plot.Series.Add(series2);
            this.chart_plot.Series.Add(series3);
            this.chart_plot.Series.Add(series4);
            this.chart_plot.Size = new System.Drawing.Size(908, 538);
            this.chart_plot.TabIndex = 1;
            this.chart_plot.Text = "chart1";
            this.chart_plot.Visible = false;
            this.chart_plot.Click += new System.EventHandler(this.chart_Click);
            this.chart_plot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_plot_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rebuild";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Rebuild);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(941, 445);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // initial_param_a
            // 
            this.initial_param_a.Location = new System.Drawing.Point(29, 12);
            this.initial_param_a.Name = "initial_param_a";
            this.initial_param_a.Size = new System.Drawing.Size(52, 20);
            this.initial_param_a.TabIndex = 5;
            this.initial_param_a.TextChanged += new System.EventHandler(this.initial_param_a_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a:";
            // 
            // initial_param_b
            // 
            this.initial_param_b.Location = new System.Drawing.Point(111, 12);
            this.initial_param_b.Name = "initial_param_b";
            this.initial_param_b.Size = new System.Drawing.Size(56, 20);
            this.initial_param_b.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "b:";
            // 
            // checkBoxFunction
            // 
            this.checkBoxFunction.AutoSize = true;
            this.checkBoxFunction.Checked = true;
            this.checkBoxFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBoxFunction.Location = new System.Drawing.Point(13, 36);
            this.checkBoxFunction.Name = "checkBoxFunction";
            this.checkBoxFunction.Size = new System.Drawing.Size(67, 17);
            this.checkBoxFunction.TabIndex = 9;
            this.checkBoxFunction.Text = "Function";
            this.checkBoxFunction.UseVisualStyleBackColor = true;
            this.checkBoxFunction.CheckedChanged += new System.EventHandler(this.checkBox_Function);
            // 
            // checkBoxSpline
            // 
            this.checkBoxSpline.AutoSize = true;
            this.checkBoxSpline.Checked = true;
            this.checkBoxSpline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxSpline.Location = new System.Drawing.Point(13, 82);
            this.checkBoxSpline.Name = "checkBoxSpline";
            this.checkBoxSpline.Size = new System.Drawing.Size(55, 17);
            this.checkBoxSpline.TabIndex = 10;
            this.checkBoxSpline.Text = "Spline";
            this.checkBoxSpline.UseVisualStyleBackColor = true;
            this.checkBoxSpline.CheckedChanged += new System.EventHandler(this.checkBox_Spline);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.файлToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Exit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Максимальная ошибка:";
            // 
            // checkBoxPoints
            // 
            this.checkBoxPoints.AutoSize = true;
            this.checkBoxPoints.Checked = true;
            this.checkBoxPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPoints.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxPoints.Location = new System.Drawing.Point(13, 59);
            this.checkBoxPoints.Name = "checkBoxPoints";
            this.checkBoxPoints.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPoints.TabIndex = 14;
            this.checkBoxPoints.Text = "Points";
            this.checkBoxPoints.UseVisualStyleBackColor = true;
            this.checkBoxPoints.CheckedChanged += new System.EventHandler(this.checkBox_Points);
            this.checkBoxPoints.Click += new System.EventHandler(this.checkBox_Points);
            // 
            // checkBoxPolynom
            // 
            this.checkBoxPolynom.AutoSize = true;
            this.checkBoxPolynom.Checked = true;
            this.checkBoxPolynom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPolynom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBoxPolynom.Location = new System.Drawing.Point(13, 105);
            this.checkBoxPolynom.Name = "checkBoxPolynom";
            this.checkBoxPolynom.Size = new System.Drawing.Size(66, 17);
            this.checkBoxPolynom.TabIndex = 15;
            this.checkBoxPolynom.Text = "Polynom";
            this.checkBoxPolynom.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowHide
            // 
            this.checkBoxShowHide.AutoSize = true;
            this.checkBoxShowHide.Checked = true;
            this.checkBoxShowHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowHide.ForeColor = System.Drawing.Color.Black;
            this.checkBoxShowHide.Location = new System.Drawing.Point(13, 13);
            this.checkBoxShowHide.Name = "checkBoxShowHide";
            this.checkBoxShowHide.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowHide.TabIndex = 16;
            this.checkBoxShowHide.Text = "Show/Hide ALL";
            this.checkBoxShowHide.UseVisualStyleBackColor = true;
            this.checkBoxShowHide.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBoxShowHide.Click += new System.EventHandler(this.checkBox_All);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(88, 27);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(50, 20);
            this.textBoxT.TabIndex = 17;
            this.textBoxT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(19, 66);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(50, 20);
            this.textBoxL.TabIndex = 18;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(159, 66);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(50, 20);
            this.textBoxR.TabIndex = 19;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(88, 106);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(50, 20);
            this.textBoxB.TabIndex = 20;
            // 
            // buttonSetTBLR
            // 
            this.buttonSetTBLR.Location = new System.Drawing.Point(88, 64);
            this.buttonSetTBLR.Name = "buttonSetTBLR";
            this.buttonSetTBLR.Size = new System.Drawing.Size(50, 22);
            this.buttonSetTBLR.TabIndex = 22;
            this.buttonSetTBLR.Text = "Set";
            this.buttonSetTBLR.UseVisualStyleBackColor = true;
            this.buttonSetTBLR.Click += new System.EventHandler(this.buttonSetTBLR_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(941, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(243, 178);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxShowHide);
            this.tabPage1.Controls.Add(this.checkBoxFunction);
            this.tabPage1.Controls.Add(this.checkBoxPolynom);
            this.tabPage1.Controls.Add(this.checkBoxSpline);
            this.tabPage1.Controls.Add(this.checkBoxPoints);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(235, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show/Hide";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxT);
            this.tabPage2.Controls.Add(this.buttonSetTBLR);
            this.tabPage2.Controls.Add(this.textBoxR);
            this.tabPage2.Controls.Add(this.textBoxL);
            this.tabPage2.Controls.Add(this.textBoxB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(235, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "T/B/L/R";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.initial_param_a);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.initial_param_b);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(235, 152);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "[a,b]";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // plot1
            // 
            this.plot1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plot1.Location = new System.Drawing.Point(41, 36);
            this.plot1.Margin = new System.Windows.Forms.Padding(0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(585, 343);
            this.plot1.TabIndex = 0;
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plot1.Click += new System.EventHandler(this.plot1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 585);
            this.Controls.Add(this.plot1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart_plot);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NM Plot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_plot)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlotView plot1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_plot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox initial_param_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initial_param_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxFunction;
        private System.Windows.Forms.CheckBox checkBoxSpline;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxPoints;
        private System.Windows.Forms.CheckBox checkBoxPolynom;
        private System.Windows.Forms.CheckBox checkBoxShowHide;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonSetTBLR;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

