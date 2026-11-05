namespace cifrario_cesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_n1.Location = new System.Drawing.Point(171, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(218, 27);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n2.Location = new System.Drawing.Point(22, 62);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(106, 15);
            this.lbl_n2.TabIndex = 1;
            this.lbl_n2.Text = "Dimmi cosa cifrare";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(143, 62);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 2;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n3.Location = new System.Drawing.Point(22, 93);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(88, 15);
            this.lbl_n3.TabIndex = 3;
            this.lbl_n3.Text = "Dimmi la chiave";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(143, 91);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 4;
            // 
            // btn_n1
            // 
            this.btn_n1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_n1.Location = new System.Drawing.Point(25, 136);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(85, 23);
            this.btn_n1.TabIndex = 5;
            this.btn_n1.Text = "CIFRATORE";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n4.Location = new System.Drawing.Point(22, 118);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(75, 15);
            this.lbl_n4.TabIndex = 6;
            this.lbl_n4.Text = "Testo cifrato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.ForeColor = System.Drawing.Color.Coral;
            this.lbl_n5.Location = new System.Drawing.Point(143, 119);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(48, 13);
            this.lbl_n5.TabIndex = 8;
            this.lbl_n5.Text = "Risultato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_n5;
    }
}

