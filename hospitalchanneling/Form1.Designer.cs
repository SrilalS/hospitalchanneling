﻿namespace hospitalchanneling
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
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "user Type";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "signup";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 34);
            this.button4.TabIndex = 13;
            this.button4.Text = "login";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(651, 360);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(121, 22);
            this.txtpw.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(651, 314);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 22);
            this.txtname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "user name";
            // 
            // comtype
            // 
            this.comtype.FormattingEnabled = true;
            this.comtype.Items.AddRange(new object[] {
            "Doctor"});
            this.comtype.Location = new System.Drawing.Point(650, 278);
            this.comtype.Name = "comtype";
            this.comtype.Size = new System.Drawing.Size(121, 24);
            this.comtype.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 734);
            this.Controls.Add(this.comtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtype;
    }
}

