namespace _1730jlindahlvariablesSample
{
    partial class frmSampleVariables
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretaxtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHamburgersSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHamburgers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotDogsSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHotDogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(123, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tax:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(243, 119);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(52, 20);
            this.txtTotal.TabIndex = 29;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(243, 93);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(52, 20);
            this.txtTax.TabIndex = 28;
            // 
            // txtPretaxtotal
            // 
            this.txtPretaxtotal.Location = new System.Drawing.Point(243, 67);
            this.txtPretaxtotal.Name = "txtPretaxtotal";
            this.txtPretaxtotal.ReadOnly = true;
            this.txtPretaxtotal.Size = new System.Drawing.Size(52, 20);
            this.txtPretaxtotal.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pretax total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHamburgersSubtotal
            // 
            this.txtHamburgersSubtotal.Location = new System.Drawing.Point(243, 41);
            this.txtHamburgersSubtotal.Name = "txtHamburgersSubtotal";
            this.txtHamburgersSubtotal.ReadOnly = true;
            this.txtHamburgersSubtotal.Size = new System.Drawing.Size(52, 20);
            this.txtHamburgersSubtotal.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "x $5.00 =";
            // 
            // txtHamburgers
            // 
            this.txtHamburgers.Location = new System.Drawing.Point(99, 41);
            this.txtHamburgers.Name = "txtHamburgers";
            this.txtHamburgers.Size = new System.Drawing.Size(47, 20);
            this.txtHamburgers.TabIndex = 22;
            this.txtHamburgers.Text = "0";
            this.txtHamburgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hamburgers:";
            // 
            // txtHotDogsSubtotal
            // 
            this.txtHotDogsSubtotal.Location = new System.Drawing.Point(244, 14);
            this.txtHotDogsSubtotal.Name = "txtHotDogsSubtotal";
            this.txtHotDogsSubtotal.ReadOnly = true;
            this.txtHotDogsSubtotal.Size = new System.Drawing.Size(52, 20);
            this.txtHotDogsSubtotal.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "x $4.00 =";
            // 
            // txtHotDogs
            // 
            this.txtHotDogs.Location = new System.Drawing.Point(99, 14);
            this.txtHotDogs.Name = "txtHotDogs";
            this.txtHotDogs.Size = new System.Drawing.Size(47, 20);
            this.txtHotDogs.TabIndex = 18;
            this.txtHotDogs.Text = "0";
            this.txtHotDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hot dogs:";
            // 
            // frmSampleVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 242);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPretaxtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHamburgersSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHamburgers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotDogsSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotDogs);
            this.Controls.Add(this.label1);
            this.Name = "frmSampleVariables";
            this.Text = "jlindahlSampleVariables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretaxtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHamburgersSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHamburgers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotDogsSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotDogs;
        private System.Windows.Forms.Label label1;
    }
}

