namespace numerical_methods2
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label15 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.button1 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBox1.Controls.Add(this.label15);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.label13);
      this.groupBox1.Controls.Add(this.textBox9);
      this.groupBox1.Controls.Add(this.textBox8);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.textBox7);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.textBox6);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.textBox5);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBox4);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(11, 11);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
      this.groupBox1.Size = new System.Drawing.Size(177, 284);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(6, 246);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(31, 13);
      this.label15.TabIndex = 19;
      this.label15.Text = "b2 = ";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(6, 224);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(31, 13);
      this.label14.TabIndex = 18;
      this.label14.Text = "b1 = ";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(6, 198);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(31, 13);
      this.label13.TabIndex = 17;
      this.label13.Text = "b0 = ";
      // 
      // textBox9
      // 
      this.textBox9.Location = new System.Drawing.Point(42, 243);
      this.textBox9.Margin = new System.Windows.Forms.Padding(2);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(44, 20);
      this.textBox9.TabIndex = 16;
      this.textBox9.Text = "0";
      this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // textBox8
      // 
      this.textBox8.Location = new System.Drawing.Point(42, 219);
      this.textBox8.Margin = new System.Windows.Forms.Padding(2);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(44, 20);
      this.textBox8.TabIndex = 15;
      this.textBox8.Text = "0,3";
      this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 141);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(0, 13);
      this.label7.TabIndex = 14;
      // 
      // textBox7
      // 
      this.textBox7.Location = new System.Drawing.Point(42, 195);
      this.textBox7.Margin = new System.Windows.Forms.Padding(2);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(44, 20);
      this.textBox7.TabIndex = 13;
      this.textBox7.Text = "0,2";
      this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 172);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(33, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "φ2 = ";
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(42, 169);
      this.textBox6.Margin = new System.Windows.Forms.Padding(2);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(44, 20);
      this.textBox6.TabIndex = 11;
      this.textBox6.Text = "0,4";
      this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 110);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(0, 13);
      this.label6.TabIndex = 10;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(42, 141);
      this.textBox5.Margin = new System.Windows.Forms.Padding(2);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(44, 20);
      this.textBox5.TabIndex = 9;
      this.textBox5.Text = "0,3";
      this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 144);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "φ1 = ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 79);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Шаг по x:";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(117, 100);
      this.textBox3.Margin = new System.Windows.Forms.Padding(2);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(49, 20);
      this.textBox3.TabIndex = 6;
      this.textBox3.Text = "10";
      this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesInt_TextFormat);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 103);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(92, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Шаг по времени:";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(117, 76);
      this.textBox4.Margin = new System.Windows.Forms.Padding(2);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(49, 20);
      this.textBox4.TabIndex = 4;
      this.textBox4.Text = "200";
      this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesInt_TextFormat);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(118, 54);
      this.textBox2.Margin = new System.Windows.Forms.Padding(2);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(49, 20);
      this.textBox2.TabIndex = 3;
      this.textBox2.Text = "1";
      this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(118, 32);
      this.textBox1.Margin = new System.Windows.Forms.Padding(2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(49, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "15";
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 57);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(108, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Время воздействия";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 32);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Длина стержня";
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
      chartArea1.AxisX.Title = "x";
      chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
      chartArea1.AxisY.Title = "y";
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(192, 11);
      this.chart1.Margin = new System.Windows.Forms.Padding(2);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(730, 399);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.Control;
      this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.button1.Location = new System.Drawing.Point(10, 299);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(167, 28);
      this.button1.TabIndex = 2;
      this.button1.Text = "Рассчитать";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(10, 399);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(168, 19);
      this.progressBar1.TabIndex = 5;
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(7, 342);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(111, 26);
      this.label9.TabIndex = 7;
      this.label9.Text = "Время выполнения: \nчасть A, секунды - ";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(110, 356);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(0, 13);
      this.label10.TabIndex = 8;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(8, 384);
      this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(103, 13);
      this.label11.TabIndex = 9;
      this.label11.Text = "часть B, секунды - ";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(110, 384);
      this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(0, 13);
      this.label12.TabIndex = 10;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(933, 428);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.groupBox1);
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Сomputational methods Lab2";
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
  }
}

