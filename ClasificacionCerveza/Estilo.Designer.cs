namespace ClasificacionCerveza
{
    partial class Estilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estilo));
            this.rtbEstilos = new System.Windows.Forms.RichTextBox();
            this.pbCervezas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCervezas)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbEstilos
            // 
            this.rtbEstilos.BackColor = System.Drawing.SystemColors.Window;
            this.rtbEstilos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEstilos.Location = new System.Drawing.Point(0, 0);
            this.rtbEstilos.Name = "rtbEstilos";
            this.rtbEstilos.ReadOnly = true;
            this.rtbEstilos.Size = new System.Drawing.Size(595, 485);
            this.rtbEstilos.TabIndex = 0;
            this.rtbEstilos.Text = resources.GetString("rtbEstilos.Text");
            // 
            // pbCervezas
            // 
            this.pbCervezas.Image = ((System.Drawing.Image)(resources.GetObject("pbCervezas.Image")));
            this.pbCervezas.Location = new System.Drawing.Point(592, 0);
            this.pbCervezas.Name = "pbCervezas";
            this.pbCervezas.Size = new System.Drawing.Size(319, 485);
            this.pbCervezas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCervezas.TabIndex = 1;
            this.pbCervezas.TabStop = false;
            // 
            // Estilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(910, 485);
            this.Controls.Add(this.pbCervezas);
            this.Controls.Add(this.rtbEstilos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Estilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estilos de Cervezas";
            ((System.ComponentModel.ISupportInitialize)(this.pbCervezas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEstilos;
        private System.Windows.Forms.PictureBox pbCervezas;
    }
}