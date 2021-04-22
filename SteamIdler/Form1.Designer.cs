namespace SteamIdler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AppIdTb = new System.Windows.Forms.TextBox();
            this.Vlabel = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveIdsCb = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(257, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start!!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AppID:";
            // 
            // AppIdTb
            // 
            this.AppIdTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AppIdTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppIdTb.ForeColor = System.Drawing.Color.White;
            this.AppIdTb.Location = new System.Drawing.Point(61, 17);
            this.AppIdTb.Name = "AppIdTb";
            this.AppIdTb.Size = new System.Drawing.Size(189, 14);
            this.AppIdTb.TabIndex = 2;
            this.AppIdTb.MouseHover += new System.EventHandler(this.AppIdTb_MouseHover);
            // 
            // Vlabel
            // 
            this.Vlabel.AutoSize = true;
            this.Vlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vlabel.Location = new System.Drawing.Point(12, 77);
            this.Vlabel.Name = "Vlabel";
            this.Vlabel.Size = new System.Drawing.Size(103, 15);
            this.Vlabel.TabIndex = 3;
            this.Vlabel.Text = "Version 1.2.0.0";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(263, 69);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(46, 34);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // saveIdsCb
            // 
            this.saveIdsCb.AutoSize = true;
            this.saveIdsCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIdsCb.ForeColor = System.Drawing.Color.White;
            this.saveIdsCb.Location = new System.Drawing.Point(15, 46);
            this.saveIdsCb.Name = "saveIdsCb";
            this.saveIdsCb.Size = new System.Drawing.Size(163, 19);
            this.saveIdsCb.TabIndex = 5;
            this.saveIdsCb.Text = "Save appids for next time";
            this.saveIdsCb.UseVisualStyleBackColor = true;
            this.saveIdsCb.CheckedChanged += new System.EventHandler(this.saveIdsCb_CheckedChanged);
            this.saveIdsCb.MouseHover += new System.EventHandler(this.saveIdsCb_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(253, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(321, 101);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveIdsCb);
            this.Controls.Add(this.Vlabel);
            this.Controls.Add(this.AppIdTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SteamIdler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AppIdTb;
        private System.Windows.Forms.Label Vlabel;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.CheckBox saveIdsCb;
        private System.Windows.Forms.Button button2;
    }
}

