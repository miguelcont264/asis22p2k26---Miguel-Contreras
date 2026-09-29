namespace capa_vista_Mantenimiento2k26
{
    partial class Frmmantenimieto_bodegas
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.btnayudas = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(-7, -5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1328, 126);
            this.navegador1.TabIndex = 0;
            // 
            // btnayudas
            // 
            this.btnayudas.Location = new System.Drawing.Point(1251, 107);
            this.btnayudas.Name = "btnayudas";
            this.btnayudas.Size = new System.Drawing.Size(155, 72);
            this.btnayudas.TabIndex = 1;
            this.btnayudas.Text = "ayudas";
            this.btnayudas.UseVisualStyleBackColor = true;
            // 
            // btnreportes
            // 
            this.btnreportes.Location = new System.Drawing.Point(1251, 216);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(155, 72);
            this.btnreportes.TabIndex = 2;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = true;
            // 
            // Frmmantenimieto_bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 588);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.btnayudas);
            this.Controls.Add(this.navegador1);
            this.Name = "Frmmantenimieto_bodegas";
            this.Text = "Frmmantenimieto_bodegas";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button btnayudas;
        private System.Windows.Forms.Button btnreportes;
    }
}