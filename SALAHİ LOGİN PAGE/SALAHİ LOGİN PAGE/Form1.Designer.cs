﻿
namespace SALAHİ_LOGİN_PAGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSİFRE = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "CYPRUS BITCOIN SYSTEM";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSİFRE
            // 
            this.txtSİFRE.BackColor = System.Drawing.SystemColors.Control;
            this.txtSİFRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSİFRE.Location = new System.Drawing.Point(301, 236);
            this.txtSİFRE.Multiline = true;
            this.txtSİFRE.Name = "txtSİFRE";
            this.txtSİFRE.PasswordChar = '*';
            this.txtSİFRE.Size = new System.Drawing.Size(215, 37);
            this.txtSİFRE.TabIndex = 2;
            // 
            // txtAD
            // 
            this.txtAD.BackColor = System.Drawing.SystemColors.Control;
            this.txtAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAD.Location = new System.Drawing.Point(301, 152);
            this.txtAD.Multiline = true;
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(215, 37);
            this.txtAD.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(314, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtSİFRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSİFRE;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

