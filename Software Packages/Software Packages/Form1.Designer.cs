namespace Software_Packages
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawLineDDA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.X1DDA = new System.Windows.Forms.TextBox();
            this.Y1DDA = new System.Windows.Forms.TextBox();
            this.X2DDA = new System.Windows.Forms.TextBox();
            this.Y2DDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Y2Bresenham = new System.Windows.Forms.TextBox();
            this.X2Bresenham = new System.Windows.Forms.TextBox();
            this.Y1Bresenham = new System.Windows.Forms.TextBox();
            this.X1Bresenham = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DrawLineBresenham = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.Radius_Circle = new System.Windows.Forms.TextBox();
            this.Y_Circle = new System.Windows.Forms.TextBox();
            this.X_Circle = new System.Windows.Forms.TextBox();
            this.Draw_circle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawLineDDA
            // 
            this.DrawLineDDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.DrawLineDDA.Location = new System.Drawing.Point(41, 130);
            this.DrawLineDDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrawLineDDA.Name = "DrawLineDDA";
            this.DrawLineDDA.Size = new System.Drawing.Size(204, 41);
            this.DrawLineDDA.TabIndex = 0;
            this.DrawLineDDA.Text = "Draw Line With DDA";
            this.DrawLineDDA.UseVisualStyleBackColor = false;
            this.DrawLineDDA.Click += new System.EventHandler(this.DrawLineDDA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point2 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(295, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 565);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // X1DDA
            // 
            this.X1DDA.Location = new System.Drawing.Point(77, 37);
            this.X1DDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X1DDA.Name = "X1DDA";
            this.X1DDA.Size = new System.Drawing.Size(67, 27);
            this.X1DDA.TabIndex = 4;
            // 
            // Y1DDA
            // 
            this.Y1DDA.Location = new System.Drawing.Point(166, 37);
            this.Y1DDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y1DDA.Name = "Y1DDA";
            this.Y1DDA.Size = new System.Drawing.Size(78, 27);
            this.Y1DDA.TabIndex = 5;
            // 
            // X2DDA
            // 
            this.X2DDA.Location = new System.Drawing.Point(77, 97);
            this.X2DDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X2DDA.Name = "X2DDA";
            this.X2DDA.Size = new System.Drawing.Size(67, 27);
            this.X2DDA.TabIndex = 6;
            // 
            // Y2DDA
            // 
            this.Y2DDA.Location = new System.Drawing.Point(166, 97);
            this.Y2DDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y2DDA.Name = "Y2DDA";
            this.Y2DDA.Size = new System.Drawing.Size(78, 27);
            this.Y2DDA.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Y2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "X2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Y1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "X1";
            // 
            // Y2Bresenham
            // 
            this.Y2Bresenham.Location = new System.Drawing.Point(166, 275);
            this.Y2Bresenham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y2Bresenham.Name = "Y2Bresenham";
            this.Y2Bresenham.Size = new System.Drawing.Size(78, 27);
            this.Y2Bresenham.TabIndex = 18;
            // 
            // X2Bresenham
            // 
            this.X2Bresenham.Location = new System.Drawing.Point(77, 275);
            this.X2Bresenham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X2Bresenham.Name = "X2Bresenham";
            this.X2Bresenham.Size = new System.Drawing.Size(67, 27);
            this.X2Bresenham.TabIndex = 17;
            // 
            // Y1Bresenham
            // 
            this.Y1Bresenham.Location = new System.Drawing.Point(166, 215);
            this.Y1Bresenham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y1Bresenham.Name = "Y1Bresenham";
            this.Y1Bresenham.Size = new System.Drawing.Size(78, 27);
            this.Y1Bresenham.TabIndex = 16;
            // 
            // X1Bresenham
            // 
            this.X1Bresenham.Location = new System.Drawing.Point(77, 215);
            this.X1Bresenham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X1Bresenham.Name = "X1Bresenham";
            this.X1Bresenham.Size = new System.Drawing.Size(67, 27);
            this.X1Bresenham.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Point2 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Point1 :";
            // 
            // DrawLineBresenham
            // 
            this.DrawLineBresenham.BackColor = System.Drawing.Color.DodgerBlue;
            this.DrawLineBresenham.Location = new System.Drawing.Point(41, 313);
            this.DrawLineBresenham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrawLineBresenham.Name = "DrawLineBresenham";
            this.DrawLineBresenham.Size = new System.Drawing.Size(204, 40);
            this.DrawLineBresenham.TabIndex = 23;
            this.DrawLineBresenham.Text = "Draw Line With Bresenham";
            this.DrawLineBresenham.UseVisualStyleBackColor = false;
            this.DrawLineBresenham.Click += new System.EventHandler(this.DrawLineBresenham_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Radius";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Y";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(102, 365);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 20);
            this.X.TabIndex = 30;
            this.X.Text = "X";
            // 
            // Radius_Circle
            // 
            this.Radius_Circle.Location = new System.Drawing.Point(73, 451);
            this.Radius_Circle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Radius_Circle.Name = "Radius_Circle";
            this.Radius_Circle.Size = new System.Drawing.Size(167, 27);
            this.Radius_Circle.TabIndex = 29;
            // 
            // Y_Circle
            // 
            this.Y_Circle.Location = new System.Drawing.Point(175, 391);
            this.Y_Circle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y_Circle.Name = "Y_Circle";
            this.Y_Circle.Size = new System.Drawing.Size(78, 27);
            this.Y_Circle.TabIndex = 27;
            // 
            // X_Circle
            // 
            this.X_Circle.Location = new System.Drawing.Point(73, 391);
            this.X_Circle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X_Circle.Name = "X_Circle";
            this.X_Circle.Size = new System.Drawing.Size(67, 27);
            this.X_Circle.TabIndex = 26;
            // 
            // Draw_circle
            // 
            this.Draw_circle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Draw_circle.Location = new System.Drawing.Point(41, 485);
            this.Draw_circle.Name = "Draw_circle";
            this.Draw_circle.Size = new System.Drawing.Size(190, 44);
            this.Draw_circle.TabIndex = 0;
            this.Draw_circle.Text = "Draw Circle";
            this.Draw_circle.UseVisualStyleBackColor = false;
            this.Draw_circle.Click += new System.EventHandler(this.Draw_circle_click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1281, 685);
            this.Controls.Add(this.Draw_circle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Radius_Circle);
            this.Controls.Add(this.Y_Circle);
            this.Controls.Add(this.X_Circle);
            this.Controls.Add(this.DrawLineBresenham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Y2Bresenham);
            this.Controls.Add(this.X2Bresenham);
            this.Controls.Add(this.Y1Bresenham);
            this.Controls.Add(this.X1Bresenham);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y2DDA);
            this.Controls.Add(this.X2DDA);
            this.Controls.Add(this.Y1DDA);
            this.Controls.Add(this.X1DDA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawLineDDA);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DrawLineDDA;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox X1DDA;
        private TextBox Y1DDA;
        private TextBox X2DDA;
        private TextBox Y2DDA;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Y2Bresenham;
        private TextBox X2Bresenham;
        private TextBox Y1Bresenham;
        private TextBox X1Bresenham;
        private Label label11;
        private Label label12;
        private Button DrawLineBresenham;
        private Label label13;
        private Label label15;
        private Label X;
        private TextBox Radius_Circle;
        private TextBox Y_Circle;
        private TextBox X_Circle;
        private Button Draw_circle;
    }
}