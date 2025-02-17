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
            this.pictureBoxH = new System.Windows.Forms.PictureBox();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.pictureBoxI = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxG = new System.Windows.Forms.PictureBox();
            this.pictureBoxR = new System.Windows.Forms.PictureBox();
            this.RGBLabel = new System.Windows.Forms.Label();
            this.HSILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).BeginInit();
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
            // pictureBoxH
            // 
            this.pictureBoxH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxH.Location = new System.Drawing.Point(1037, 41);
            this.pictureBoxH.Name = "pictureBoxH";
            this.pictureBoxH.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxH.TabIndex = 109;
            this.pictureBoxH.TabStop = false;
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxS.Location = new System.Drawing.Point(1037, 183);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxS.TabIndex = 110;
            this.pictureBoxS.TabStop = false;
            // 
            // pictureBoxI
            // 
            this.pictureBoxI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxI.Location = new System.Drawing.Point(1037, 328);
            this.pictureBoxI.Name = "pictureBoxI";
            this.pictureBoxI.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxI.TabIndex = 111;
            this.pictureBoxI.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxB.Location = new System.Drawing.Point(848, 328);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxB.TabIndex = 114;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxG
            // 
            this.pictureBoxG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxG.Location = new System.Drawing.Point(848, 183);
            this.pictureBoxG.Name = "pictureBoxG";
            this.pictureBoxG.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxG.TabIndex = 113;
            this.pictureBoxG.TabStop = false;
            // 
            // pictureBoxR
            // 
            this.pictureBoxR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxR.Location = new System.Drawing.Point(848, 41);
            this.pictureBoxR.Name = "pictureBoxR";
            this.pictureBoxR.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxR.TabIndex = 112;
            this.pictureBoxR.TabStop = false;
            // 
            // RGBLabel
            // 
            this.RGBLabel.AutoSize = true;
            this.RGBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.RGBLabel.Location = new System.Drawing.Point(845, 17);
            this.RGBLabel.Name = "RGBLabel";
            this.RGBLabel.Size = new System.Drawing.Size(33, 15);
            this.RGBLabel.TabIndex = 115;
            this.RGBLabel.Text = "RGB";
            this.RGBLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // HSILabel
            // 
            this.HSILabel.AutoSize = true;
            this.HSILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.HSILabel.Location = new System.Drawing.Point(1034, 17);
            this.HSILabel.Name = "HSILabel";
            this.HSILabel.Size = new System.Drawing.Size(27, 15);
            this.HSILabel.TabIndex = 116;
            this.HSILabel.Text = "HSI";
            this.HSILabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.HSILabel);
            this.Controls.Add(this.RGBLabel);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxG);
            this.Controls.Add(this.pictureBoxR);
            this.Controls.Add(this.pictureBoxI);
            this.Controls.Add(this.pictureBoxS);
            this.Controls.Add(this.pictureBoxH);
            this.Controls.Add(this.RemoveBrightness);
            this.Controls.Add(this.AddBrightness);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button AddBrightness;
        private System.Windows.Forms.Button RemoveBrightness;
        private System.Windows.Forms.PictureBox pictureBoxH;
        private System.Windows.Forms.PictureBox pictureBoxS;
        private System.Windows.Forms.PictureBox pictureBoxI;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxG;
        private System.Windows.Forms.PictureBox pictureBoxR;
        private System.Windows.Forms.Label RGBLabel;
        private System.Windows.Forms.Label HSILabel;
    }
}

