namespace WindowsFormsApp1
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
            this.buybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.cctextBox = new System.Windows.Forms.TextBox();
            this.exptextBox = new System.Windows.Forms.TextBox();
            this.ziptextBox = new System.Windows.Forms.TextBox();
            this.amttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.feetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buybutton
            // 
            this.buybutton.Location = new System.Drawing.Point(333, 315);
            this.buybutton.Name = "buybutton";
            this.buybutton.Size = new System.Drawing.Size(75, 23);
            this.buybutton.TabIndex = 0;
            this.buybutton.Text = "BUY";
            this.buybutton.UseVisualStyleBackColor = true;
            this.buybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(146, 70);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 2;
            // 
            // cctextBox
            // 
            this.cctextBox.Location = new System.Drawing.Point(146, 98);
            this.cctextBox.Name = "cctextBox";
            this.cctextBox.Size = new System.Drawing.Size(100, 22);
            this.cctextBox.TabIndex = 3;
            // 
            // exptextBox
            // 
            this.exptextBox.Location = new System.Drawing.Point(146, 126);
            this.exptextBox.Name = "exptextBox";
            this.exptextBox.Size = new System.Drawing.Size(100, 22);
            this.exptextBox.TabIndex = 4;
            // 
            // ziptextBox
            // 
            this.ziptextBox.Location = new System.Drawing.Point(146, 154);
            this.ziptextBox.Name = "ziptextBox";
            this.ziptextBox.Size = new System.Drawing.Size(100, 22);
            this.ziptextBox.TabIndex = 5;
            // 
            // amttextBox
            // 
            this.amttextBox.Location = new System.Drawing.Point(146, 182);
            this.amttextBox.Name = "amttextBox";
            this.amttextBox.Size = new System.Drawing.Size(100, 22);
            this.amttextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "CC#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exp Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(496, 315);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // feetextBox
            // 
            this.feetextBox.Location = new System.Drawing.Point(146, 245);
            this.feetextBox.Name = "feetextBox";
            this.feetextBox.Size = new System.Drawing.Size(100, 22);
            this.feetextBox.TabIndex = 14;
            this.feetextBox.TextChanged += new System.EventHandler(this.feetextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.feetextBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amttextBox);
            this.Controls.Add(this.ziptextBox);
            this.Controls.Add(this.exptextBox);
            this.Controls.Add(this.cctextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox cctextBox;
        private System.Windows.Forms.TextBox exptextBox;
        private System.Windows.Forms.TextBox ziptextBox;
        private System.Windows.Forms.TextBox amttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.TextBox feetextBox;
        private System.Windows.Forms.Label label6;
    }
}

