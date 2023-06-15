namespace EncuestasForm
{
    partial class FormListaDeInforme
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
            this.listaInf = new System.Windows.Forms.ListBox();
            this.btnLAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaInf
            // 
            this.listaInf.FormattingEnabled = true;
            this.listaInf.ItemHeight = 16;
            this.listaInf.Location = new System.Drawing.Point(49, 12);
            this.listaInf.Name = "listaInf";
            this.listaInf.Size = new System.Drawing.Size(699, 388);
            this.listaInf.TabIndex = 0;
            // 
            // btnLAceptar
            // 
            this.btnLAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLAceptar.Location = new System.Drawing.Point(366, 415);
            this.btnLAceptar.Name = "btnLAceptar";
            this.btnLAceptar.Size = new System.Drawing.Size(80, 23);
            this.btnLAceptar.TabIndex = 1;
            this.btnLAceptar.Text = "Aceptar";
            this.btnLAceptar.UseVisualStyleBackColor = true;
            // 
            // FormListaDeInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLAceptar);
            this.Controls.Add(this.listaInf);
            this.Name = "FormListaDeInforme";
            this.Text = "FormListaDeInforme";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLAceptar;
        public System.Windows.Forms.ListBox listaInf;
    }
}