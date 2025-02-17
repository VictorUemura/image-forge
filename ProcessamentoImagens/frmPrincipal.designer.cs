namespace ProcessamentoImagens
{
    partial class frmPrincipal
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
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddBrightness = new System.Windows.Forms.Button();
            this.RemoveBrightness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(5, 512);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.openImage);
            // 
            // AddBrightness
            // 
            this.AddBrightness.Location = new System.Drawing.Point(611, 12);
            this.AddBrightness.Name = "AddBrightness";
            this.AddBrightness.Size = new System.Drawing.Size(75, 23);
            this.AddBrightness.TabIndex = 107;
            this.AddBrightness.Text = "+ Brightness";
            this.AddBrightness.UseVisualStyleBackColor = true;
            this.AddBrightness.Click += new System.EventHandler(this.AddBrightnessButton);
            // 
            // RemoveBrightness
            // 
            this.RemoveBrightness.Location = new System.Drawing.Point(611, 41);
            this.RemoveBrightness.Name = "RemoveBrightness";
            this.RemoveBrightness.Size = new System.Drawing.Size(75, 23);
            this.RemoveBrightness.TabIndex = 108;
            this.RemoveBrightness.Text = "- Brightness";
            this.RemoveBrightness.UseVisualStyleBackColor = true;
            this.RemoveBrightness.Click += new System.EventHandler(this.RemoveBrightnessButton);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.RemoveBrightness);
            this.Controls.Add(this.AddBrightness);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button AddBrightness;
        private System.Windows.Forms.Button RemoveBrightness;
    }
}

