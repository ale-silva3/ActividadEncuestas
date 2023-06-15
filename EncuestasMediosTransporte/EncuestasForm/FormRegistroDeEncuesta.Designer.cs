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
            this.c = new System.Windows.Forms.Button();
            this.chbUsaAuto = new System.Windows.Forms.CheckBox();
            this.chbUsaTP = new System.Windows.Forms.CheckBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.gbDistancia = new System.Windows.Forms.GroupBox();
            this.gbOpcionesRegistro.SuspendLayout();
            this.gbDistancia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcionesRegistro
            // 
            this.gbOpcionesRegistro.Controls.Add(this.chbUsaTP);
            this.gbOpcionesRegistro.Controls.Add(this.chbUsaBici);
            this.gbOpcionesRegistro.Controls.Add(this.chbUsaAuto);
            this.gbOpcionesRegistro.Location = new System.Drawing.Point(229, 12);
            this.gbOpcionesRegistro.Name = "gbOpcionesRegistro";
            this.gbOpcionesRegistro.Size = new System.Drawing.Size(349, 121);
            this.gbOpcionesRegistro.TabIndex = 0;
            this.gbOpcionesRegistro.TabStop = false;
            this.gbOpcionesRegistro.Text = "Modo de transporte habitual";
            // 
            // chbUsaBici
            // 
            this.chbUsaBici.AutoSize = true;
            this.chbUsaBici.Location = new System.Drawing.Point(158, 29);
            this.chbUsaBici.Name = "chbUsaBici";
            this.chbUsaBici.Size = new System.Drawing.Size(122, 20);
            this.chbUsaBici.TabIndex = 0;
            this.chbUsaBici.Text = "¿Usa Bicicleta?";
            this.chbUsaBici.UseVisualStyleBackColor = true;
            // 
            // btnROk
            // 
            this.btnROk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnROk.Location = new System.Drawing.Point(290, 329);
            this.btnROk.Name = "btnROk";
            this.btnROk.Size = new System.Drawing.Size(75, 23);
            this.btnROk.TabIndex = 1;
            this.btnROk.Text = "Aceptar";
            this.btnROk.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c.Location = new System.Drawing.Point(445, 329);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(75, 23);
            this.c.TabIndex = 2;
            this.c.Text = "Cancelar";
            this.c.UseVisualStyleBackColor = true;
            // 
            // chbUsaAuto
            // 
            this.chbUsaAuto.AutoSize = true;
            this.chbUsaAuto.Location = new System.Drawing.Point(158, 55);
            this.chbUsaAuto.Name = "chbUsaAuto";
            this.chbUsaAuto.Size = new System.Drawing.Size(98, 20);
            this.chbUsaAuto.TabIndex = 1;
            this.chbUsaAuto.Text = "¿Usa Auto?";
            this.chbUsaAuto.UseVisualStyleBackColor = true;
            // 
            // chbUsaTP
            // 
            this.chbUsaTP.AutoSize = true;
            this.chbUsaTP.Location = new System.Drawing.Point(158, 81);
            this.chbUsaTP.Name = "chbUsaTP";
            this.chbUsaTP.Size = new System.Drawing.Size(185, 20);
            this.chbUsaTP.TabIndex = 2;
            this.chbUsaTP.Text = "¿Usa Transporte Publico?";
            this.chbUsaTP.UseVisualStyleBackColor = true;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(158, 53);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(127, 22);
            this.txtDistancia.TabIndex = 4;
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(22, 56);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(110, 16);
            this.lbDistancia.TabIndex = 5;
            this.lbDistancia.Text = "Distancia en (km)";
            // 
            // gbDistancia
            // 
            this.gbDistancia.Controls.Add(this.lbDistancia);
            this.gbDistancia.Controls.Add(this.txtDistancia);
            this.gbDistancia.Location = new System.Drawing.Point(229, 149);
            this.gbDistancia.Name = "gbDistancia";
            this.gbDistancia.Size = new System.Drawing.Size(349, 121);
            this.gbDistancia.TabIndex = 3;
            this.gbDistancia.TabStop = false;
            this.gbDistancia.Text = "Sobre el destino al Trabajo/Estudio";
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDistancia);
            this.Controls.Add(this.c);
            this.Controls.Add(this.btnROk);
            this.Controls.Add(this.gbOpcionesRegistro);
            this.Name = "FormRegistroDeEncuesta";
            this.Text = "FormRegistroDeEncuesta";
            this.gbOpcionesRegistro.ResumeLayout(false);
            this.gbOpcionesRegistro.PerformLayout();
            this.gbDistancia.ResumeLayout(false);
            this.gbDistancia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcionesRegistro;
        private System.Windows.Forms.Button btnROk;
        private System.Windows.Forms.Button c;
        public System.Windows.Forms.CheckBox chbUsaBici;
        public System.Windows.Forms.CheckBox chbUsaAuto;
        public System.Windows.Forms.CheckBox chbUsaTP;
        private System.Windows.Forms.Label lbDistancia;
        public System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox gbDistancia;
    }
}