namespace AFPProyectSQA.Views
{
    partial class MainMenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuView));
            this.RequestPensionbtn = new System.Windows.Forms.Button();
            this.RequestChangebtn = new System.Windows.Forms.Button();
            this.RequestPensionlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestPensionbtn
            // 
            this.RequestPensionbtn.BackColor = System.Drawing.Color.Transparent;
            this.RequestPensionbtn.Image = ((System.Drawing.Image)(resources.GetObject("RequestPensionbtn.Image")));
            this.RequestPensionbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RequestPensionbtn.Location = new System.Drawing.Point(86, 143);
            this.RequestPensionbtn.Name = "RequestPensionbtn";
            this.RequestPensionbtn.Size = new System.Drawing.Size(136, 128);
            this.RequestPensionbtn.TabIndex = 0;
            this.RequestPensionbtn.UseMnemonic = false;
            this.RequestPensionbtn.UseVisualStyleBackColor = false;
            this.RequestPensionbtn.Click += new System.EventHandler(this.RequestPensionbtn_Click);
            // 
            // RequestChangebtn
            // 
            this.RequestChangebtn.BackColor = System.Drawing.Color.Transparent;
            this.RequestChangebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestChangebtn.Image = ((System.Drawing.Image)(resources.GetObject("RequestChangebtn.Image")));
            this.RequestChangebtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RequestChangebtn.Location = new System.Drawing.Point(303, 143);
            this.RequestChangebtn.Name = "RequestChangebtn";
            this.RequestChangebtn.Size = new System.Drawing.Size(136, 128);
            this.RequestChangebtn.TabIndex = 1;
            this.RequestChangebtn.UseMnemonic = false;
            this.RequestChangebtn.UseVisualStyleBackColor = false;
            this.RequestChangebtn.Click += new System.EventHandler(this.RequestChangebtn_Click);
            // 
            // RequestPensionlbl
            // 
            this.RequestPensionlbl.AutoSize = true;
            this.RequestPensionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestPensionlbl.Location = new System.Drawing.Point(57, 296);
            this.RequestPensionlbl.Name = "RequestPensionlbl";
            this.RequestPensionlbl.Size = new System.Drawing.Size(190, 85);
            this.RequestPensionlbl.TabIndex = 2;
            this.RequestPensionlbl.Text = "SOLICITUD DE PENSION\r\n\r\nEn este apartado, podra \r\nagregar una solicitud \r\nde pens" +
    "ión.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 102);
            this.label1.TabIndex = 3;
            this.label1.Text = "SOLICITUD DE CAMBIO\r\n DE AFP\r\n\r\nEn este apartado, podra \r\nagregar una solicitud \r" +
    "\nde cambio de AFP.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenido al sistema!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(511, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(919, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestPensionlbl);
            this.Controls.Add(this.RequestChangebtn);
            this.Controls.Add(this.RequestPensionbtn);
            this.MaximizeBox = false;
            this.Name = "MainMenuView";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequestPensionbtn;
        private System.Windows.Forms.Button RequestChangebtn;
        private System.Windows.Forms.Label RequestPensionlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}