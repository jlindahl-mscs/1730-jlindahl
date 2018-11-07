namespace _1730jlindahl2G
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
            this.input01aTextBox = new System.Windows.Forms.TextBox();
            this.resultSwitch01TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultIf01TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultElseif01TextBox = new System.Windows.Forms.TextBox();
            this.resultNestedIf01TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultSwitchDefault01TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultIfDefault01TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultElseIfDefault01TextBox = new System.Windows.Forms.TextBox();
            this.resultNestedIfDefault01TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.input02aTextBox = new System.Windows.Forms.TextBox();
            this.resultNestedIf02TextBox = new System.Windows.Forms.TextBox();
            this.resultElseIf02TextBox = new System.Windows.Forms.TextBox();
            this.resultIf02TextBox = new System.Windows.Forms.TextBox();
            this.resultSwitch02TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input01aTextBox
            // 
            this.input01aTextBox.Location = new System.Drawing.Point(156, 25);
            this.input01aTextBox.Name = "input01aTextBox";
            this.input01aTextBox.Size = new System.Drawing.Size(61, 20);
            this.input01aTextBox.TabIndex = 0;
            this.input01aTextBox.Text = "R";
            // 
            // resultSwitch01TextBox
            // 
            this.resultSwitch01TextBox.Location = new System.Drawing.Point(300, 25);
            this.resultSwitch01TextBox.Name = "resultSwitch01TextBox";
            this.resultSwitch01TextBox.ReadOnly = true;
            this.resultSwitch01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultSwitch01TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1) Switch R/C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2) If R/C";
            // 
            // resultIf01TextBox
            // 
            this.resultIf01TextBox.Location = new System.Drawing.Point(300, 51);
            this.resultIf01TextBox.Name = "resultIf01TextBox";
            this.resultIf01TextBox.ReadOnly = true;
            this.resultIf01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultIf01TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "3) Elseif R/C";
            // 
            // resultElseif01TextBox
            // 
            this.resultElseif01TextBox.Location = new System.Drawing.Point(300, 78);
            this.resultElseif01TextBox.Name = "resultElseif01TextBox";
            this.resultElseif01TextBox.ReadOnly = true;
            this.resultElseif01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultElseif01TextBox.TabIndex = 8;
            // 
            // resultNestedIf01TextBox
            // 
            this.resultNestedIf01TextBox.Location = new System.Drawing.Point(300, 103);
            this.resultNestedIf01TextBox.Name = "resultNestedIf01TextBox";
            this.resultNestedIf01TextBox.ReadOnly = true;
            this.resultNestedIf01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultNestedIf01TextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "4) Nested If R/C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "5) Switch with default";
            // 
            // resultSwitchDefault01TextBox
            // 
            this.resultSwitchDefault01TextBox.Location = new System.Drawing.Point(300, 129);
            this.resultSwitchDefault01TextBox.Name = "resultSwitchDefault01TextBox";
            this.resultSwitchDefault01TextBox.ReadOnly = true;
            this.resultSwitchDefault01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultSwitchDefault01TextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "6) if R/C, default";
            // 
            // resultIfDefault01TextBox
            // 
            this.resultIfDefault01TextBox.Location = new System.Drawing.Point(300, 155);
            this.resultIfDefault01TextBox.Name = "resultIfDefault01TextBox";
            this.resultIfDefault01TextBox.ReadOnly = true;
            this.resultIfDefault01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultIfDefault01TextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "7) Elseif R/C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "8) Nested if-else";
            // 
            // resultElseIfDefault01TextBox
            // 
            this.resultElseIfDefault01TextBox.Location = new System.Drawing.Point(300, 182);
            this.resultElseIfDefault01TextBox.Name = "resultElseIfDefault01TextBox";
            this.resultElseIfDefault01TextBox.ReadOnly = true;
            this.resultElseIfDefault01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultElseIfDefault01TextBox.TabIndex = 17;
            // 
            // resultNestedIfDefault01TextBox
            // 
            this.resultNestedIfDefault01TextBox.Location = new System.Drawing.Point(300, 211);
            this.resultNestedIfDefault01TextBox.Name = "resultNestedIfDefault01TextBox";
            this.resultNestedIfDefault01TextBox.ReadOnly = true;
            this.resultNestedIfDefault01TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultNestedIfDefault01TextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "1) Switch R/C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "2) If R/C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "3) Elseif R/C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "4) Nested If R/C";
            // 
            // input02aTextBox
            // 
            this.input02aTextBox.Location = new System.Drawing.Point(156, 235);
            this.input02aTextBox.Name = "input02aTextBox";
            this.input02aTextBox.Size = new System.Drawing.Size(61, 20);
            this.input02aTextBox.TabIndex = 23;
            this.input02aTextBox.Text = "R";
            // 
            // resultNestedIf02TextBox
            // 
            this.resultNestedIf02TextBox.Location = new System.Drawing.Point(300, 320);
            this.resultNestedIf02TextBox.Name = "resultNestedIf02TextBox";
            this.resultNestedIf02TextBox.ReadOnly = true;
            this.resultNestedIf02TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultNestedIf02TextBox.TabIndex = 27;
            // 
            // resultElseIf02TextBox
            // 
            this.resultElseIf02TextBox.Location = new System.Drawing.Point(300, 291);
            this.resultElseIf02TextBox.Name = "resultElseIf02TextBox";
            this.resultElseIf02TextBox.ReadOnly = true;
            this.resultElseIf02TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultElseIf02TextBox.TabIndex = 26;
            // 
            // resultIf02TextBox
            // 
            this.resultIf02TextBox.Location = new System.Drawing.Point(300, 264);
            this.resultIf02TextBox.Name = "resultIf02TextBox";
            this.resultIf02TextBox.ReadOnly = true;
            this.resultIf02TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultIf02TextBox.TabIndex = 25;
            // 
            // resultSwitch02TextBox
            // 
            this.resultSwitch02TextBox.Location = new System.Drawing.Point(300, 238);
            this.resultSwitch02TextBox.Name = "resultSwitch02TextBox";
            this.resultSwitch02TextBox.ReadOnly = true;
            this.resultSwitch02TextBox.Size = new System.Drawing.Size(61, 20);
            this.resultSwitch02TextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 395);
            this.Controls.Add(this.resultNestedIf02TextBox);
            this.Controls.Add(this.resultElseIf02TextBox);
            this.Controls.Add(this.resultIf02TextBox);
            this.Controls.Add(this.resultSwitch02TextBox);
            this.Controls.Add(this.input02aTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultNestedIfDefault01TextBox);
            this.Controls.Add(this.resultElseIfDefault01TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultIfDefault01TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultSwitchDefault01TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultNestedIf01TextBox);
            this.Controls.Add(this.resultElseif01TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultIf01TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultSwitch01TextBox);
            this.Controls.Add(this.input01aTextBox);
            this.Name = "Form1";
            this.Text = "jlindahl1g1 Switches, if else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input01aTextBox;
        private System.Windows.Forms.TextBox resultSwitch01TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultIf01TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultElseif01TextBox;
        private System.Windows.Forms.TextBox resultNestedIf01TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultSwitchDefault01TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultIfDefault01TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultElseIfDefault01TextBox;
        private System.Windows.Forms.TextBox resultNestedIfDefault01TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox input02aTextBox;
        private System.Windows.Forms.TextBox resultNestedIf02TextBox;
        private System.Windows.Forms.TextBox resultElseIf02TextBox;
        private System.Windows.Forms.TextBox resultIf02TextBox;
        private System.Windows.Forms.TextBox resultSwitch02TextBox;
    }
}

