using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Basico8 : Form
    {
        System.Windows.Forms.Timer TiempoDeCambio = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer TiempoDePrueba = new System.Windows.Forms.Timer();
        public Basico8()
        {
            InitializeComponent();
        }

        private void Basico8_Load(object sender, EventArgs e)
        {
            Actualizar();
            TiempoDeCambio.Interval = 10000;
            TiempoDePrueba.Interval = 120000;
            TiempoDeCambio.Tick += new EventHandler(TiempoCumplido);
            TiempoDePrueba.Tick += new EventHandler(FinDeTiempo);
            TiempoDePrueba.Start();
        }

        String salto = Environment.NewLine;
        Random Ran = new Random();
        int Ingreso;
        int Pregunta = 0;
        int Operacion1;
        int Operacion2;
        ArrayList Respuestas = new ArrayList();

        private void TiempoCumplido(object sender, EventArgs e)
        {
            btn_cambio.Hide();
            TiempoDeCambio.Stop();
        }
        private void FinDeTiempo(object sender, EventArgs e)
        {
            TiempoDePrueba.Stop();
            MuestraResultados();
        }

        protected void Elegir()
        {
            try
            {
                btn_cambio.Show();
                TiempoDeCambio.Start();
                Operacion1 = Ran.Next(1, 4);
                Operacion2 = Ran.Next(1, 3);
                switch (Operacion1)
                {
                    case 1:
                        txt_operacion1.Text = "+";
                        txt_operacion2.Text = "+";
                        txt_Num1.Text = Convert.ToString(Ran.Next(1, 101));
                        txt_Num2.Text = Convert.ToString(Ran.Next(1, 101));
                        txt_Num3.Text = Convert.ToString(Ran.Next(1, 101));
                        break;
                    case 2:
                        txt_operacion1.Text = "-";
                        txt_operacion2.Text = "-";
                        txt_Num1.Text = Convert.ToString(Ran.Next(1, 101));
                        txt_Num2.Text = Convert.ToString(Ran.Next(1, Convert.ToInt32(txt_Num1.Text)));
                        txt_Num3.Text = Convert.ToString(Ran.Next(1, Convert.ToInt32(txt_Num2.Text)));
                        break;
                    case 3:
                        txt_operacion1.Text = "x";
                        txt_Num1.Text = Convert.ToString(Ran.Next(1, 101));
                        txt_Num2.Text = Convert.ToString(Ran.Next(1, 11));
                        break;
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido configurar ");
            }
        }

        private void Actualizar()
        {
            Elegir();
            txt_restultado.Text = "";
            lbl_NumPregunta.Text = Convert.ToString(Pregunta + 1);
        }

        private void MuestraResultados()
        {
            String Mensaje = "";
            for (int i = 0; i < Respuestas.Count; i++)
            {
                Mensaje += "Pregunta #" + (i + 1) + " :" + Respuestas[i].ToString() + "." + salto;
            }
            MessageBox.Show("Respuestas" + salto +
                Mensaje, "Resultados Finales",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
