using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestasForm
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegEncuesta_Click(object sender, EventArgs e)
        {
            FormRegistroDeEncuesta fRegistro = new FormRegistroDeEncuesta();

            if (fRegistro.ShowDialog() == DialogResult.OK) 
            {
                Encuesta nuevo = new Encuesta();

                Console.WriteLine("Modo de transporte habitual");

                nuevo.UsaBicicleta = fRegistro.chbUsaBici.Checked;//Consulta("¿Usa bicleta?: S/N");
                nuevo.UsaAuto = fRegistro.chbUsaAuto.Checked;//Consulta("¿Usa Automóvil?: S/N");
                nuevo.UsaTransportePublico = fRegistro.chbUsaTP.Checked;//Consulta("¿Usa Transporte público?: S/N");

                //Console.WriteLine("¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)\n");
                nuevo.DistanciaASuDestino = Convert.ToDouble(Console.ReadLine());

                bool puedeSerContactado = false;//Consulta("¿Puede ser contactado?: S/N");
                if (puedeSerContactado == true)
                {
                    //Console.Write("Email: ");
                    nuevo.Email = Console.ReadLine();
                    //Console.Write("\n");
                }

                proceso.RegistrarEncuesta(nuevo, puedeSerContactado);

                //Console.WriteLine("\nEncuesta procesada!");
            }

        }
    }
}
