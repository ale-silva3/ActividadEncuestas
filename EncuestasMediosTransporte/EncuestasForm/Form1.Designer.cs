namespace EncuestasForm
{
    partial class Form1
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
            this.btnRegEncuesta = new System.Windows.Forms.Button();
            this.btnListarInforme = new System.Windows.Forms.Button();
            this.btnListarContactables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegEncuesta
            // 
            this.btnRegEncuesta.Location = new System.Drawing.Point(294, 94);
            this.btnRegEncuesta.Name = "btnRegEncuesta";
            this.btnRegEncuesta.Size = new System.Drawing.Size(214, 51);
            this.btnRegEncuesta.TabIndex = 0;
            this.btnRegEncuesta.Text = "Registro De Encuesta";
            this.btnRegEncuesta.UseVisualStyleBackColor = true;
            this.btnRegEncuesta.Click += new System.EventHandler(this.btnRegEncuesta_Click);
            // 
            // btnListarInforme
            // 
            this.btnListarInforme.Location = new System.Drawing.Point(294, 180);
            this.btnListarInforme.Name = "btnListarInforme";
            this.btnListarInforme.Size = new System.Drawing.Size(214, 51);
            this.btnListarInforme.TabIndex = 1;
            this.btnListarInforme.Text = "Listar Informes";
            this.btnListarInforme.UseVisualStyleBackColor = true;
            this.btnListarInforme.Click += new System.EventHandler(this.btnListarInforme_Click);
            // 
            // btnListarContactables
            // 
            this.btnListarContactables.Location = new System.Drawing.Point(294, 266);
            this.btnListarContactables.Name = "btnListarContactables";
            this.btnListarContactables.Size = new System.Drawing.Size(214, 51);
            this.btnListarContactables.TabIndex = 2;
            this.btnListarContactables.Text = "Listar Contactables";
            this.btnListarContactables.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarContactables);
            this.Controls.Add(this.btnListarInforme);
            this.Controls.Add(this.btnRegEncuesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegEncuesta;
        private System.Windows.Forms.Button btnListarInforme;
        private System.Windows.Forms.Button btnListarContactables;
    }
}

