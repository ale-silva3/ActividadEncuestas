namespace EncuestasForm
{
    partial class FormRegistroDeEncuesta
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
            this.gbOpcionesRegistro = new System.Windows.Forms.GroupBox();
            this.chbUsaBici = new System.Windows.Forms.CheckBox();
            this.btnROk = new System.Windows.Forms.Button();
            this.btnRCancel = new System.Windows.Forms.Button();
            this.chbUsaAuto = new System.Windows.Forms.CheckBox();
            this.chbUsaTP = new System.Windows.Forms.CheckBox();
            this.gbOpcionesRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcionesRegistro
            // 
            this.gbOpcionesRegistro.Controls.Add(this.chbUsaTP);
            this.gbOpcionesRegistro.Controls.Add(this.chbUsaBici);
            this.gbOpcionesRegistro.Controls.Add(this.chbUsaAuto);
            this.gbOpcionesRegistro.Location = new System.Drawing.Point(290, 91);
            this.gbOpcionesRegistro.Name = "gbOpcionesRegistro";
            this.gbOpcionesRegistro.Size = new System.Drawing.Size(230, 166);
            this.gbOpcionesRegistro.TabIndex = 0;
            this.gbOpcionesRegistro.TabStop = false;
            this.gbOpcionesRegistro.Text = "OPCIONES";
            // 
            // chbUsaBici
            // 
            this.chbUsaBici.AutoSize = true;
            this.chbUsaBici.Location = new System.Drawing.Point(25, 49);
            this.chbUsaBici.Name = "chbUsaBici";
            this.chbUsaBici.Size = new System.Drawing.Size(122, 20);
            this.chbUsaBici.TabIndex = 0;
            this.chbUsaBici.Text = "¿Usa Bicicleta?";
            this.chbUsaBici.UseVisualStyleBackColor = true;
            // 
            // btnROk
            // 
            this.btnROk.Location = new System.Drawing.Point(290, 329);
            this.btnROk.Name = "btnROk";
            this.btnROk.Size = new System.Drawing.Size(75, 23);
            this.btnROk.TabIndex = 1;
            this.btnROk.Text = "Aceptar";
            this.btnROk.UseVisualStyleBackColor = true;
            // 
            // btnRCancel
            // 
            this.btnRCancel.Location = new System.Drawing.Point(445, 329);
            this.btnRCancel.Name = "btnRCancel";
            this.btnRCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRCancel.TabIndex = 2;
            this.btnRCancel.Text = "Cancelar";
            this.btnRCancel.UseVisualStyleBackColor = true;
            // 
            // chbUsaAuto
            // 
            this.chbUsaAuto.AutoSize = true;
            this.chbUsaAuto.Location = new System.Drawing.Point(25, 75);
            this.chbUsaAuto.Name = "chbUsaAuto";
            this.chbUsaAuto.Size = new System.Drawing.Size(98, 20);
            this.chbUsaAuto.TabIndex = 1;
            this.chbUsaAuto.Text = "¿Usa Auto?";
            this.chbUsaAuto.UseVisualStyleBackColor = true;
            // 
            // chbUsaTP
            // 
            this.chbUsaTP.AutoSize = true;
            this.chbUsaTP.Location = new System.Drawing.Point(25, 101);
            this.chbUsaTP.Name = "chbUsaTP";
            this.chbUsaTP.Size = new System.Drawing.Size(185, 20);
            this.chbUsaTP.TabIndex = 2;
            this.chbUsaTP.Text = "¿Usa Transporte Publico?";
            this.chbUsaTP.UseVisualStyleBackColor = true;
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRCancel);
            this.Controls.Add(this.btnROk);
            this.Controls.Add(this.gbOpcionesRegistro);
            this.Name = "FormRegistroDeEncuesta";
            this.Text = "FormRegistroDeEncuesta";
            this.gbOpcionesRegistro.ResumeLayout(false);
            this.gbOpcionesRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcionesRegistro;
        private System.Windows.Forms.Button btnROk;
        private System.Windows.Forms.Button btnRCancel;
        public System.Windows.Forms.CheckBox chbUsaBici;
        public System.Windows.Forms.CheckBox chbUsaAuto;
        public System.Windows.Forms.CheckBox chbUsaTP;
    }
}