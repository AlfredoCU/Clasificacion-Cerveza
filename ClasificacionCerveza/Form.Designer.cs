namespace ClasificacionCerveza
{
    partial class ClasificacionCerveza
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClasificacionCerveza));
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnInf = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblAlc = new System.Windows.Forms.Label();
            this.trbAlc = new System.Windows.Forms.TrackBar();
            this.lblTem = new System.Windows.Forms.Label();
            this.trbTem = new System.Windows.Forms.TrackBar();
            this.lblSab = new System.Windows.Forms.Label();
            this.trbSab = new System.Windows.Forms.TrackBar();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnCervezas = new System.Windows.Forms.Button();
            this.pbMaridaje = new System.Windows.Forms.PictureBox();
            this.lblMar = new System.Windows.Forms.Label();
            this.btnEst = new System.Windows.Forms.Button();
            this.lblEst = new System.Windows.Forms.Label();
            this.ttipMsj = new System.Windows.Forms.ToolTip(this.components);
            this.gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSab)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaridaje)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.btnInf);
            this.gbControles.Controls.Add(this.btnRes);
            this.gbControles.Controls.Add(this.lblAlc);
            this.gbControles.Controls.Add(this.trbAlc);
            this.gbControles.Controls.Add(this.lblTem);
            this.gbControles.Controls.Add(this.trbTem);
            this.gbControles.Controls.Add(this.lblSab);
            this.gbControles.Controls.Add(this.trbSab);
            this.gbControles.Location = new System.Drawing.Point(12, 12);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(387, 301);
            this.gbControles.TabIndex = 0;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // btnInf
            // 
            this.btnInf.Image = ((System.Drawing.Image)(resources.GetObject("btnInf.Image")));
            this.btnInf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInf.Location = new System.Drawing.Point(39, 243);
            this.btnInf.Name = "btnInf";
            this.btnInf.Size = new System.Drawing.Size(149, 41);
            this.btnInf.TabIndex = 7;
            this.btnInf.Text = "Información";
            this.btnInf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInf.UseVisualStyleBackColor = true;
            this.btnInf.Click += new System.EventHandler(this.btnInf_Click);
            // 
            // btnRes
            // 
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRes.Location = new System.Drawing.Point(203, 243);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(143, 41);
            this.btnRes.TabIndex = 6;
            this.btnRes.Text = "Resultados";
            this.btnRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblAlc
            // 
            this.lblAlc.AutoSize = true;
            this.lblAlc.Location = new System.Drawing.Point(6, 178);
            this.lblAlc.Name = "lblAlc";
            this.lblAlc.Size = new System.Drawing.Size(69, 21);
            this.lblAlc.TabIndex = 5;
            this.lblAlc.Text = "Alcohol";
            // 
            // trbAlc
            // 
            this.trbAlc.Location = new System.Drawing.Point(6, 202);
            this.trbAlc.Maximum = 900;
            this.trbAlc.Minimum = 80;
            this.trbAlc.Name = "trbAlc";
            this.trbAlc.Size = new System.Drawing.Size(375, 45);
            this.trbAlc.TabIndex = 4;
            this.trbAlc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbAlc.Value = 80;
            this.trbAlc.Scroll += new System.EventHandler(this.trbAlc_Scroll);
            this.trbAlc.MouseHover += new System.EventHandler(this.trbAlc_MouseHover);
            // 
            // lblTem
            // 
            this.lblTem.AutoSize = true;
            this.lblTem.Location = new System.Drawing.Point(6, 106);
            this.lblTem.Name = "lblTem";
            this.lblTem.Size = new System.Drawing.Size(113, 21);
            this.lblTem.TabIndex = 3;
            this.lblTem.Text = "Temperatura";
            // 
            // trbTem
            // 
            this.trbTem.Location = new System.Drawing.Point(6, 130);
            this.trbTem.Maximum = 1300;
            this.trbTem.Minimum = 200;
            this.trbTem.Name = "trbTem";
            this.trbTem.Size = new System.Drawing.Size(375, 45);
            this.trbTem.TabIndex = 2;
            this.trbTem.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTem.Value = 200;
            this.trbTem.Scroll += new System.EventHandler(this.trbTem_Scroll);
            this.trbTem.MouseHover += new System.EventHandler(this.trbTem_MouseHover);
            // 
            // lblSab
            // 
            this.lblSab.AutoSize = true;
            this.lblSab.Location = new System.Drawing.Point(6, 34);
            this.lblSab.Name = "lblSab";
            this.lblSab.Size = new System.Drawing.Size(55, 21);
            this.lblSab.TabIndex = 1;
            this.lblSab.Text = "Sabor";
            // 
            // trbSab
            // 
            this.trbSab.Location = new System.Drawing.Point(6, 58);
            this.trbSab.Maximum = 120;
            this.trbSab.Name = "trbSab";
            this.trbSab.Size = new System.Drawing.Size(375, 45);
            this.trbSab.TabIndex = 0;
            this.trbSab.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbSab.Scroll += new System.EventHandler(this.trbSab_Scroll);
            this.trbSab.MouseHover += new System.EventHandler(this.trbSab_MouseHover);
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.rtbResultados);
            this.gbResultados.Location = new System.Drawing.Point(416, 12);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(507, 301);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Estilos de cervezas recomendadas ";
            // 
            // rtbResultados
            // 
            this.rtbResultados.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResultados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultados.ForeColor = System.Drawing.Color.White;
            this.rtbResultados.Location = new System.Drawing.Point(3, 23);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.ReadOnly = true;
            this.rtbResultados.Size = new System.Drawing.Size(501, 275);
            this.rtbResultados.TabIndex = 0;
            this.rtbResultados.Text = "";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnCervezas);
            this.gbInfo.Controls.Add(this.pbMaridaje);
            this.gbInfo.Controls.Add(this.lblMar);
            this.gbInfo.Controls.Add(this.btnEst);
            this.gbInfo.Controls.Add(this.lblEst);
            this.gbInfo.Location = new System.Drawing.Point(12, 319);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(911, 227);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Información";
            // 
            // btnCervezas
            // 
            this.btnCervezas.Image = ((System.Drawing.Image)(resources.GetObject("btnCervezas.Image")));
            this.btnCervezas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCervezas.Location = new System.Drawing.Point(278, 36);
            this.btnCervezas.Name = "btnCervezas";
            this.btnCervezas.Size = new System.Drawing.Size(222, 41);
            this.btnCervezas.TabIndex = 8;
            this.btnCervezas.Text = "Tabla de Cervezas";
            this.btnCervezas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCervezas.UseVisualStyleBackColor = true;
            this.btnCervezas.Click += new System.EventHandler(this.btnCervezas_Click);
            // 
            // pbMaridaje
            // 
            this.pbMaridaje.Image = ((System.Drawing.Image)(resources.GetObject("pbMaridaje.Image")));
            this.pbMaridaje.Location = new System.Drawing.Point(530, 37);
            this.pbMaridaje.Name = "pbMaridaje";
            this.pbMaridaje.Size = new System.Drawing.Size(353, 171);
            this.pbMaridaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaridaje.TabIndex = 66;
            this.pbMaridaje.TabStop = false;
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.Location = new System.Drawing.Point(26, 145);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(396, 63);
            this.lblMar.TabIndex = 10;
            this.lblMar.Text = "Maridaje: El maridaje con cerveza permite realiza \r\nla combinación de múltiples e" +
    "stilos con una gran \r\ncantidad de platos.";
            // 
            // btnEst
            // 
            this.btnEst.Image = ((System.Drawing.Image)(resources.GetObject("btnEst.Image")));
            this.btnEst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEst.Location = new System.Drawing.Point(30, 37);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(222, 40);
            this.btnEst.TabIndex = 8;
            this.btnEst.Text = "Información de Estilos";
            this.btnEst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(26, 103);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(70, 21);
            this.lblEst.TabIndex = 8;
            this.lblEst.Text = "Estilo(s):";
            // 
            // ClasificacionCerveza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbControles);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ClasificacionCerveza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clasificación de Cervezas";
            this.gbControles.ResumeLayout(false);
            this.gbControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSab)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaridaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnInf;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblAlc;
        private System.Windows.Forms.TrackBar trbAlc;
        private System.Windows.Forms.Label lblTem;
        private System.Windows.Forms.TrackBar trbTem;
        private System.Windows.Forms.Label lblSab;
        private System.Windows.Forms.TrackBar trbSab;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.PictureBox pbMaridaje;
        private System.Windows.Forms.ToolTip ttipMsj;
        private System.Windows.Forms.Button btnCervezas;
    }
}

