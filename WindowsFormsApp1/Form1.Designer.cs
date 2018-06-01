using System.Windows.Controls;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            chartArea4.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea4.Name = "ChartArea1";
            this.chart_plot.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_plot.Legends.Add(legend4);
            this.chart_plot.Location = new System.Drawing.Point(15, 36);
            this.chart_plot.Name = "chart_plot";
            this.chart_plot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Blue;
            series13.Legend = "Legend1";
            series13.LegendText = "Function";
            series13.Name = "Function";
            series13.ShadowColor = System.Drawing.SystemColors.ControlDarkDark;
            series13.ShadowOffset = 1;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series14.Legend = "Legend1";
            series14.LegendText = "Points";
            series14.MarkerBorderColor = System.Drawing.Color.Blue;
            series14.MarkerBorderWidth = 5;
            series14.MarkerColor = System.Drawing.Color.WhiteSmoke;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star6;
            series14.Name = "Points";
            series14.ShadowOffset = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Red;
            series15.Legend = "Legend1";
            series15.LegendText = "Spline";
            series15.Name = "Spline";
            series15.ShadowColor = System.Drawing.SystemColors.ControlDarkDark;
            series15.ShadowOffset = 1;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.Lime;
            series16.Legend = "Legend1";
            series16.Name = "Polynom";
            series16.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series16.ShadowOffset = 1;
            this.chart_plot.Series.Add(series13);
            this.chart_plot.Series.Add(series14);
            this.chart_plot.Series.Add(series15);
            this.chart_plot.Series.Add(series16);
            this.chart_plot.Size = new System.Drawing.Size(908, 538);
            this.chart_plot.TabIndex = 1;
            this.chart_plot.Text = "chart1";
            this.chart_plot.Click += new System.EventHandler(this.chart_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1302, 24);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 22);
            this.button3.TabIndex = 22;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox4);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 585);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

