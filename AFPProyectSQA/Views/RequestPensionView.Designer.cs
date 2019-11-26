namespace AFPProyectSQA.Views
{
    partial class RequestPensionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.RequestPension = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Motivotxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitar pension";
            // 
            // RequestPension
            // 
            this.RequestPension.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestPension.Location = new System.Drawing.Point(454, 287);
            this.RequestPension.Name = "RequestPension";
            this.RequestPension.Size = new System.Drawing.Size(204, 72);
            this.RequestPension.TabIndex = 1;
            this.RequestPension.Text = "Crear solicitud";
            this.RequestPension.UseVisualStyleBackColor = true;
            this.RequestPension.Click += new System.EventHandler(this.RequestPension_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notas importnates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 175);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Para la pensión de vejez debe \r\nhaber cumplido los sesenta (60) años.\r\n\r\nDebe pr" +
    "esentar:\r\n​*Extracto de su Acta de Nacimiento\r\n*Copia de su Cédula de Identidad." +
    "\r\n\r\n";
            // 
            // Motivotxtbox
            // 
            this.Motivotxtbox.Location = new System.Drawing.Point(454, 120);
            this.Motivotxtbox.Multiline = true;
            this.Motivotxtbox.Name = "Motivotxtbox";
            this.Motivotxtbox.Size = new System.Drawing.Size(204, 149);
            this.Motivotxtbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motivo";
            // 
            // RequestPensionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Motivotxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestPension);
            this.Controls.Add(this.label1);
            this.Name = "RequestPensionView";
            this.Text = "RequestPensionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RequestPension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Motivotxtbox;
        private System.Windows.Forms.Label label4;
    }
}