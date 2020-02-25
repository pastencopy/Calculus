namespace Calculus
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcPredatorPrey = new System.Windows.Forms.Button();
            this.btnSimpleDifferential = new System.Windows.Forms.Button();
            this.btnSimpleDifferential2 = new System.Windows.Forms.Button();
            this.btnSimpleDifferential3 = new System.Windows.Forms.Button();
            this.btnSimpleDifferential4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSimpleDifferential11 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSimpleDifferential10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSimpleDifferential9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpleDifferential7 = new System.Windows.Forms.Button();
            this.btnSimpleDifferential6 = new System.Windows.Forms.Button();
            this.btnSimpleDifferential5 = new System.Windows.Forms.Button();
            this.btnSimpleDifferential8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLorenz = new System.Windows.Forms.Button();
            this.chkUseXYLine = new System.Windows.Forms.CheckBox();
            this.btnSimpleDifferential13 = new System.Windows.Forms.Button();
            this.btnSimpleDifferential12 = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcPredatorPrey
            // 
            this.btnCalcPredatorPrey.Location = new System.Drawing.Point(6, 174);
            this.btnCalcPredatorPrey.Name = "btnCalcPredatorPrey";
            this.btnCalcPredatorPrey.Size = new System.Drawing.Size(213, 54);
            this.btnCalcPredatorPrey.TabIndex = 2;
            this.btnCalcPredatorPrey.Text = "predator–prey 방정식";
            this.btnCalcPredatorPrey.UseVisualStyleBackColor = true;
            this.btnCalcPredatorPrey.Click += new System.EventHandler(this.btnCalcPredatorPrey_Click);
            // 
            // btnSimpleDifferential
            // 
            this.btnSimpleDifferential.Location = new System.Drawing.Point(6, 20);
            this.btnSimpleDifferential.Name = "btnSimpleDifferential";
            this.btnSimpleDifferential.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential.TabIndex = 3;
            this.btnSimpleDifferential.Text = "y\' = 2y";
            this.btnSimpleDifferential.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential.Click += new System.EventHandler(this.btnSimpleDifferential_Click);
            // 
            // btnSimpleDifferential2
            // 
            this.btnSimpleDifferential2.Location = new System.Drawing.Point(6, 61);
            this.btnSimpleDifferential2.Name = "btnSimpleDifferential2";
            this.btnSimpleDifferential2.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential2.TabIndex = 4;
            this.btnSimpleDifferential2.Text = "y\' =  2";
            this.btnSimpleDifferential2.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential2.Click += new System.EventHandler(this.btnSimpleDifferential2_Click);
            // 
            // btnSimpleDifferential3
            // 
            this.btnSimpleDifferential3.Location = new System.Drawing.Point(6, 102);
            this.btnSimpleDifferential3.Name = "btnSimpleDifferential3";
            this.btnSimpleDifferential3.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential3.TabIndex = 5;
            this.btnSimpleDifferential3.Text = "y\' =  cos(x)";
            this.btnSimpleDifferential3.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential3.Click += new System.EventHandler(this.btnSimpleDifferential3_Click);
            // 
            // btnSimpleDifferential4
            // 
            this.btnSimpleDifferential4.Location = new System.Drawing.Point(6, 143);
            this.btnSimpleDifferential4.Name = "btnSimpleDifferential4";
            this.btnSimpleDifferential4.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential4.TabIndex = 6;
            this.btnSimpleDifferential4.Text = "y\' =  -y";
            this.btnSimpleDifferential4.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential4.Click += new System.EventHandler(this.btnSimpleDifferential4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential7);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential6);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential5);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential4);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential2);
            this.groupBox1.Controls.Add(this.btnSimpleDifferential3);
            this.groupBox1.Location = new System.Drawing.Point(752, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 558);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "미분 방정식 풀이 구하기 (ODE)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "F(x) = c -1/x";
            // 
            // btnSimpleDifferential11
            // 
            this.btnSimpleDifferential11.Location = new System.Drawing.Point(6, 389);
            this.btnSimpleDifferential11.Name = "btnSimpleDifferential11";
            this.btnSimpleDifferential11.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential11.TabIndex = 22;
            this.btnSimpleDifferential11.Text = "y\' = x^(-2)";
            this.btnSimpleDifferential11.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential11.Click += new System.EventHandler(this.btnSimpleDifferential11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "F(x) = x²";
            // 
            // btnSimpleDifferential10
            // 
            this.btnSimpleDifferential10.Location = new System.Drawing.Point(6, 348);
            this.btnSimpleDifferential10.Name = "btnSimpleDifferential10";
            this.btnSimpleDifferential10.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential10.TabIndex = 20;
            this.btnSimpleDifferential10.Text = "y\' = 2x";
            this.btnSimpleDifferential10.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential10.Click += new System.EventHandler(this.btnSimpleDifferential10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "F(x) = ⅓x³ - x² + x";
            // 
            // btnSimpleDifferential9
            // 
            this.btnSimpleDifferential9.Location = new System.Drawing.Point(6, 307);
            this.btnSimpleDifferential9.Name = "btnSimpleDifferential9";
            this.btnSimpleDifferential9.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential9.TabIndex = 18;
            this.btnSimpleDifferential9.Text = "y\' = x² - 2x + 1";
            this.btnSimpleDifferential9.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential9.Click += new System.EventHandler(this.btnSimpleDifferential9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "F(x) = e(x) - cos(x)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "F(x) = sin(x) - cos(x)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "F(x) = ln(x)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "F(x) = (e^-x)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "F(x) = sin(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "F(x) = 2x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "F(x) = e^2x";
            // 
            // btnSimpleDifferential7
            // 
            this.btnSimpleDifferential7.Location = new System.Drawing.Point(6, 266);
            this.btnSimpleDifferential7.Name = "btnSimpleDifferential7";
            this.btnSimpleDifferential7.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential7.TabIndex = 9;
            this.btnSimpleDifferential7.Text = "y\' =  e + sin(x)";
            this.btnSimpleDifferential7.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential7.Click += new System.EventHandler(this.btnSimpleDifferential7_Click);
            // 
            // btnSimpleDifferential6
            // 
            this.btnSimpleDifferential6.Location = new System.Drawing.Point(6, 225);
            this.btnSimpleDifferential6.Name = "btnSimpleDifferential6";
            this.btnSimpleDifferential6.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential6.TabIndex = 8;
            this.btnSimpleDifferential6.Text = "y\' =  cos(x) + sin(x)";
            this.btnSimpleDifferential6.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential6.Click += new System.EventHandler(this.btnSimpleDifferential6_Click);
            // 
            // btnSimpleDifferential5
            // 
            this.btnSimpleDifferential5.Location = new System.Drawing.Point(6, 184);
            this.btnSimpleDifferential5.Name = "btnSimpleDifferential5";
            this.btnSimpleDifferential5.Size = new System.Drawing.Size(147, 35);
            this.btnSimpleDifferential5.TabIndex = 7;
            this.btnSimpleDifferential5.Text = "y\' =  1/y";
            this.btnSimpleDifferential5.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential5.Click += new System.EventHandler(this.btnSimpleDifferential5_Click);
            // 
            // btnSimpleDifferential8
            // 
            this.btnSimpleDifferential8.Location = new System.Drawing.Point(6, 43);
            this.btnSimpleDifferential8.Name = "btnSimpleDifferential8";
            this.btnSimpleDifferential8.Size = new System.Drawing.Size(213, 53);
            this.btnSimpleDifferential8.TabIndex = 17;
            this.btnSimpleDifferential8.Text = "du/dt = 3u+4v\r\ndv/dt =−4u+3v";
            this.btnSimpleDifferential8.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential8.Click += new System.EventHandler(this.btnSimpleDifferential8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLorenz);
            this.groupBox2.Controls.Add(this.chkUseXYLine);
            this.groupBox2.Controls.Add(this.btnSimpleDifferential13);
            this.groupBox2.Controls.Add(this.btnSimpleDifferential12);
            this.groupBox2.Controls.Add(this.btnCalcPredatorPrey);
            this.groupBox2.Controls.Add(this.btnSimpleDifferential8);
            this.groupBox2.Location = new System.Drawing.Point(1056, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 558);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnLorenz
            // 
            this.btnLorenz.Location = new System.Drawing.Point(6, 295);
            this.btnLorenz.Name = "btnLorenz";
            this.btnLorenz.Size = new System.Drawing.Size(213, 56);
            this.btnLorenz.TabIndex = 26;
            this.btnLorenz.Text = "Lorenz 방정식";
            this.btnLorenz.UseVisualStyleBackColor = true;
            this.btnLorenz.Click += new System.EventHandler(this.btnLorenz_Click);
            // 
            // chkUseXYLine
            // 
            this.chkUseXYLine.AutoSize = true;
            this.chkUseXYLine.Location = new System.Drawing.Point(6, 20);
            this.chkUseXYLine.Name = "chkUseXYLine";
            this.chkUseXYLine.Size = new System.Drawing.Size(112, 16);
            this.chkUseXYLine.TabIndex = 25;
            this.chkUseXYLine.Text = "x-y 연결 그래프";
            this.chkUseXYLine.UseVisualStyleBackColor = true;
            // 
            // btnSimpleDifferential13
            // 
            this.btnSimpleDifferential13.Image = global::Calculus.Properties.Resources.example13;
            this.btnSimpleDifferential13.Location = new System.Drawing.Point(6, 233);
            this.btnSimpleDifferential13.Name = "btnSimpleDifferential13";
            this.btnSimpleDifferential13.Size = new System.Drawing.Size(213, 56);
            this.btnSimpleDifferential13.TabIndex = 24;
            this.btnSimpleDifferential13.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential13.Click += new System.EventHandler(this.btnSimpleDifferential13_Click);
            // 
            // btnSimpleDifferential12
            // 
            this.btnSimpleDifferential12.Image = global::Calculus.Properties.Resources.example12;
            this.btnSimpleDifferential12.Location = new System.Drawing.Point(6, 102);
            this.btnSimpleDifferential12.Name = "btnSimpleDifferential12";
            this.btnSimpleDifferential12.Size = new System.Drawing.Size(213, 65);
            this.btnSimpleDifferential12.TabIndex = 23;
            this.btnSimpleDifferential12.UseVisualStyleBackColor = true;
            this.btnSimpleDifferential12.Click += new System.EventHandler(this.btnSimpleDifferential12_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(734, 558);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Differential Solver";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnCalcPredatorPrey;
        private System.Windows.Forms.Button btnSimpleDifferential;
        private System.Windows.Forms.Button btnSimpleDifferential2;
        private System.Windows.Forms.Button btnSimpleDifferential3;
        private System.Windows.Forms.Button btnSimpleDifferential4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSimpleDifferential5;
        private System.Windows.Forms.Button btnSimpleDifferential6;
        private System.Windows.Forms.Button btnSimpleDifferential7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSimpleDifferential8;
        private System.Windows.Forms.Button btnSimpleDifferential9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSimpleDifferential10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimpleDifferential11;
        private System.Windows.Forms.Button btnSimpleDifferential12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSimpleDifferential13;
        private System.Windows.Forms.CheckBox chkUseXYLine;
        private System.Windows.Forms.Button btnLorenz;
        private System.Windows.Forms.Label label10;
    }
}

