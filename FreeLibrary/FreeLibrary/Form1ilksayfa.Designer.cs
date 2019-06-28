namespace FreeLibrary
{
    partial class Form1ilksayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1ilksayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxkullanıcı = new System.Windows.Forms.ComboBox();
            this.pcbxgiris = new System.Windows.Forms.PictureBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxgiris)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(176, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(176, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // cmbxkullanıcı
            // 
            this.cmbxkullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxkullanıcı.FormattingEnabled = true;
            this.cmbxkullanıcı.Location = new System.Drawing.Point(319, 138);
            this.cmbxkullanıcı.Name = "cmbxkullanıcı";
            this.cmbxkullanıcı.Size = new System.Drawing.Size(226, 24);
            this.cmbxkullanıcı.TabIndex = 5;
            // 
            // pcbxgiris
            // 
            this.pcbxgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbxgiris.BackgroundImage")));
            this.pcbxgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxgiris.Location = new System.Drawing.Point(391, 245);
            this.pcbxgiris.Name = "pcbxgiris";
            this.pcbxgiris.Size = new System.Drawing.Size(94, 44);
            this.pcbxgiris.TabIndex = 6;
            this.pcbxgiris.TabStop = false;
            this.pcbxgiris.Click += new System.EventHandler(this.pcbxgiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(319, 197);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(226, 25);
            this.txtsifre.TabIndex = 7;
            // 
            // Form1ilksayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 434);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.pcbxgiris);
            this.Controls.Add(this.cmbxkullanıcı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1ilksayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1ilksayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxgiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxkullanıcı;
        private System.Windows.Forms.PictureBox pcbxgiris;
        private System.Windows.Forms.TextBox txtsifre;
    }
}

