namespace pryTrabajoIntegradorQuiligotti
{
    partial class frmLocales
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
            this.btnLocalQuenaken = new System.Windows.Forms.Button();
            this.btnLocalOnas = new System.Windows.Forms.Button();
            this.btnLocalTobas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLocalQuenaken
            // 
            this.btnLocalQuenaken.Location = new System.Drawing.Point(53, 77);
            this.btnLocalQuenaken.Name = "btnLocalQuenaken";
            this.btnLocalQuenaken.Size = new System.Drawing.Size(132, 23);
            this.btnLocalQuenaken.TabIndex = 0;
            this.btnLocalQuenaken.Text = "LOCAL QUENAKEN";
            this.btnLocalQuenaken.UseVisualStyleBackColor = true;
            this.btnLocalQuenaken.Click += new System.EventHandler(this.btnLocalQuenaken_Click);
            // 
            // btnLocalOnas
            // 
            this.btnLocalOnas.Location = new System.Drawing.Point(53, 146);
            this.btnLocalOnas.Name = "btnLocalOnas";
            this.btnLocalOnas.Size = new System.Drawing.Size(132, 23);
            this.btnLocalOnas.TabIndex = 1;
            this.btnLocalOnas.Text = "LOCAL ONAS";
            this.btnLocalOnas.UseVisualStyleBackColor = true;
            this.btnLocalOnas.Click += new System.EventHandler(this.btnLocalOnas_Click);
            // 
            // btnLocalTobas
            // 
            this.btnLocalTobas.Location = new System.Drawing.Point(53, 224);
            this.btnLocalTobas.Name = "btnLocalTobas";
            this.btnLocalTobas.Size = new System.Drawing.Size(132, 23);
            this.btnLocalTobas.TabIndex = 2;
            this.btnLocalTobas.Text = "LOCAL TOBAS";
            this.btnLocalTobas.UseVisualStyleBackColor = true;
            this.btnLocalTobas.Click += new System.EventHandler(this.btnLocalTobas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE UN LOCAL";
            // 
            // frmLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocalTobas);
            this.Controls.Add(this.btnLocalOnas);
            this.Controls.Add(this.btnLocalQuenaken);
            this.Name = "frmLocales";
            this.Text = "LOCALES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalQuenaken;
        private System.Windows.Forms.Button btnLocalOnas;
        private System.Windows.Forms.Button btnLocalTobas;
        private System.Windows.Forms.Label label1;
    }
}

