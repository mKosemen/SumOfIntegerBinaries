namespace IntegerIkililerinToplami
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAssignment = new System.Windows.Forms.Button();
            this.nudCift = new System.Windows.Forms.NumericUpDown();
            this.rbtnAuto = new System.Windows.Forms.RadioButton();
            this.rbtnManuel = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCift)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAssignment
            // 
            this.btnAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAssignment.Location = new System.Drawing.Point(12, 250);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(75, 36);
            this.btnAssignment.TabIndex = 0;
            this.btnAssignment.Text = "Assignment";
            this.btnAssignment.UseVisualStyleBackColor = false;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // nudCift
            // 
            this.nudCift.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCift.ForeColor = System.Drawing.Color.Black;
            this.nudCift.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCift.Location = new System.Drawing.Point(173, 124);
            this.nudCift.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCift.Name = "nudCift";
            this.nudCift.ReadOnly = true;
            this.nudCift.Size = new System.Drawing.Size(76, 25);
            this.nudCift.TabIndex = 1;
            this.nudCift.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCift.ValueChanged += new System.EventHandler(this.nudCift_ValueChanged);
            // 
            // rbtnAuto
            // 
            this.rbtnAuto.AutoSize = true;
            this.rbtnAuto.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtnAuto.Location = new System.Drawing.Point(172, 218);
            this.rbtnAuto.Name = "rbtnAuto";
            this.rbtnAuto.Size = new System.Drawing.Size(60, 23);
            this.rbtnAuto.TabIndex = 2;
            this.rbtnAuto.TabStop = true;
            this.rbtnAuto.Text = "Auto";
            this.rbtnAuto.UseVisualStyleBackColor = true;
            this.rbtnAuto.CheckedChanged += new System.EventHandler(this.rbtnAuto_CheckedChanged);
            // 
            // rbtnManuel
            // 
            this.rbtnManuel.AutoSize = true;
            this.rbtnManuel.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnManuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtnManuel.Location = new System.Drawing.Point(172, 189);
            this.rbtnManuel.Name = "rbtnManuel";
            this.rbtnManuel.Size = new System.Drawing.Size(77, 23);
            this.rbtnManuel.TabIndex = 3;
            this.rbtnManuel.TabStop = true;
            this.rbtnManuel.Text = "Manuel";
            this.rbtnManuel.UseVisualStyleBackColor = true;
            this.rbtnManuel.CheckedChanged += new System.EventHandler(this.rbtnManuel_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Location = new System.Drawing.Point(93, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 36);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 37);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn7.Location = new System.Drawing.Point(3, 89);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 37);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn6.Location = new System.Drawing.Point(105, 46);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 37);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn5.Location = new System.Drawing.Point(54, 46);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 37);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn4.Location = new System.Drawing.Point(3, 46);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 37);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn3.Location = new System.Drawing.Point(105, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 37);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn2.Location = new System.Drawing.Point(54, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 37);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn8.Location = new System.Drawing.Point(54, 89);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 37);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn9.Location = new System.Drawing.Point(105, 89);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 37);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumClick);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(12, 12);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(237, 96);
            this.tbxResult.TabIndex = 14;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btn8);
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Controls.Add(this.btn7);
            this.pnl1.Controls.Add(this.btn9);
            this.pnl1.Controls.Add(this.btn6);
            this.pnl1.Controls.Add(this.btn2);
            this.pnl1.Controls.Add(this.btn5);
            this.pnl1.Controls.Add(this.btn3);
            this.pnl1.Controls.Add(this.btn4);
            this.pnl1.Location = new System.Drawing.Point(12, 114);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(155, 130);
            this.pnl1.TabIndex = 15;
            this.pnl1.Click += new System.EventHandler(this.NumClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(174, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Ink Free", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Blue;
            this.lblCounter.Location = new System.Drawing.Point(173, 160);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(73, 16);
            this.lblCounter.TabIndex = 16;
            this.lblCounter.Text = "Counter: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 292);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnManuel);
            this.Controls.Add(this.rbtnAuto);
            this.Controls.Add(this.nudCift);
            this.Controls.Add(this.btnAssignment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCift)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.NumericUpDown nudCift;
        private System.Windows.Forms.RadioButton rbtnAuto;
        private System.Windows.Forms.RadioButton rbtnManuel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCounter;
    }
}

