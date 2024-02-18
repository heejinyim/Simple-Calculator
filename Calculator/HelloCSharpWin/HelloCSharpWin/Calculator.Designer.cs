namespace HelloCSharpWin
{
    partial class Calculator
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
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumPlus = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton7 = new System.Windows.Forms.Button();
            this.NumButton0 = new System.Windows.Forms.Button();
            this.NumSub = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.NumEqual = new System.Windows.Forms.Button();
            this.NumDiv = new System.Windows.Forms.Button();
            this.NumMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(24, 325);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(88, 88);
            this.NumButton1.TabIndex = 0;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(118, 325);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(88, 88);
            this.NumButton2.TabIndex = 1;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.Color.White;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumScreen.Location = new System.Drawing.Point(24, 27);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(367, 70);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(306, 420);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(85, 89);
            this.NumPlus.TabIndex = 3;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(212, 325);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(88, 88);
            this.NumButton3.TabIndex = 4;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(212, 231);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(88, 88);
            this.NumButton6.TabIndex = 7;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(118, 231);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(88, 88);
            this.NumButton5.TabIndex = 6;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(24, 231);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(88, 88);
            this.NumButton4.TabIndex = 5;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(212, 137);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(88, 88);
            this.NumButton9.TabIndex = 10;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(118, 137);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(88, 88);
            this.NumButton8.TabIndex = 9;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton7
            // 
            this.NumButton7.Location = new System.Drawing.Point(24, 137);
            this.NumButton7.Name = "NumButton7";
            this.NumButton7.Size = new System.Drawing.Size(88, 88);
            this.NumButton7.TabIndex = 8;
            this.NumButton7.Text = "7";
            this.NumButton7.UseVisualStyleBackColor = true;
            this.NumButton7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton0
            // 
            this.NumButton0.Location = new System.Drawing.Point(118, 419);
            this.NumButton0.Name = "NumButton0";
            this.NumButton0.Size = new System.Drawing.Size(88, 88);
            this.NumButton0.TabIndex = 11;
            this.NumButton0.Text = "0";
            this.NumButton0.UseVisualStyleBackColor = true;
            this.NumButton0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumSub
            // 
            this.NumSub.Location = new System.Drawing.Point(306, 325);
            this.NumSub.Name = "NumSub";
            this.NumSub.Size = new System.Drawing.Size(85, 89);
            this.NumSub.TabIndex = 12;
            this.NumSub.Text = "-";
            this.NumSub.UseVisualStyleBackColor = true;
            this.NumSub.Click += new System.EventHandler(this.Operator_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(27, 419);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(85, 89);
            this.NumClear.TabIndex = 13;
            this.NumClear.Text = "C";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // NumEqual
            // 
            this.NumEqual.Location = new System.Drawing.Point(215, 419);
            this.NumEqual.Name = "NumEqual";
            this.NumEqual.Size = new System.Drawing.Size(85, 89);
            this.NumEqual.TabIndex = 14;
            this.NumEqual.Text = "=";
            this.NumEqual.UseVisualStyleBackColor = true;
            this.NumEqual.Click += new System.EventHandler(this.Operator_Click);
            // 
            // NumDiv
            // 
            this.NumDiv.Location = new System.Drawing.Point(306, 137);
            this.NumDiv.Name = "NumDiv";
            this.NumDiv.Size = new System.Drawing.Size(85, 89);
            this.NumDiv.TabIndex = 16;
            this.NumDiv.Text = "/";
            this.NumDiv.UseVisualStyleBackColor = true;
            this.NumDiv.Click += new System.EventHandler(this.Operator_Click);
            // 
            // NumMulti
            // 
            this.NumMulti.Location = new System.Drawing.Point(306, 232);
            this.NumMulti.Name = "NumMulti";
            this.NumMulti.Size = new System.Drawing.Size(85, 89);
            this.NumMulti.TabIndex = 15;
            this.NumMulti.Text = "*";
            this.NumMulti.UseVisualStyleBackColor = true;
            this.NumMulti.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 526);
            this.Controls.Add(this.NumDiv);
            this.Controls.Add(this.NumMulti);
            this.Controls.Add(this.NumEqual);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.NumSub);
            this.Controls.Add(this.NumButton0);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton7);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumPlus;
        private System.Windows.Forms.Button NumButton3;
        private System.Windows.Forms.Button NumButton6;
        private System.Windows.Forms.Button NumButton5;
        private System.Windows.Forms.Button NumButton4;
        private System.Windows.Forms.Button NumButton9;
        private System.Windows.Forms.Button NumButton8;
        private System.Windows.Forms.Button NumButton7;
        private System.Windows.Forms.Button NumButton0;
        private System.Windows.Forms.Button NumSub;
        private System.Windows.Forms.Button NumClear;
        private System.Windows.Forms.Button NumEqual;
        private System.Windows.Forms.Button NumDiv;
        private System.Windows.Forms.Button NumMulti;
    }
}

