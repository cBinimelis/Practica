using System;
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
    public partial class Basico5 : Form
    {
        System.Windows.Forms.Timer TiempoDeCambio = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer TiempoDePrueba = new System.Windows.Forms.Timer();
        public Basico5()
        {
            InitializeComponent();
        }

        private void Basico5_Load(object sender, EventArgs e)
        {
            TiempoDeCambio.Interval = 15000;
            TiempoDePrueba.Interval = 120000;
            TiempoDeCambio.Tick += new EventHandler(TiempoCumplido);
            TiempoDePrueba.Tick += new EventHandler(FinDeTiempo);
        }


        String salto = Environment.NewLine;
        Random Ran = new Random();
        int Ingreso;
        int Pregunta = 0;
        int Operacion;
        String[] Respuestas = new String[] { };


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
                Operacion = Ran.Next(1, 4);
                switch (Operacion)
                {
                    case 1:
                        txt_operacion.Text = "+";
                        txt_Num1.Text = Convert.ToString(Ran.Next(1, 11));
                        txt_Num2.Text = Convert.ToString(Ran.Next(1, 11));
                        break;
                    case 2:
                        txt_operacion.Text = "-";
                        txt_Num1.Text = Convert.ToString(Ran.Next(1, 11));
                        txt_Num2.Text = Convert.ToString(Ran.Next(1, Convert.ToInt32(txt_Num1.Text)));
                        break;
                    case 3:
                        txt_operacion.Text = "x";
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
            for (int i = 0; i < Respuestas.Length; i++)
            {
                Mensaje += "Pregunta #" + i + 1 + " :" + salto + ".";
            }
            MessageBox.Show("Respuestas" + salto +
                Mensaje, "Resultados Finales",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;
                Ingreso = Convert.ToInt32(txt_restultado.Text);
                switch (Operacion)
                {
                    case 1:
                        resultado = Convert.ToInt32(txt_Num1.Text) + Convert.ToInt32(txt_Num2.Text);
                        if (Ingreso == resultado)
                        {
                            Respuestas[Pregunta] = "Respuesta correcta";
                            Pregunta++;
                            Actualizar();
                        }
                        else
                        {
                            Respuestas[Pregunta] = "Respuesta incorrecta";
                            Pregunta++;
                            Actualizar();
                        }
                        break;
                    case 2:
                        resultado = Convert.ToInt32(txt_Num1.Text) - Convert.ToInt32(txt_Num2.Text);
                        if (Ingreso == resultado)
                        {
                            Respuestas[Pregunta] = "Respuesta correcta";
                            Pregunta++;
                            Actualizar();
                        }
                        else
                        {
                            Respuestas[Pregunta] = "Respuesta incorrecta";
                            Pregunta++;
                            Actualizar();
                        }
                        break;
                    case 3:
                        resultado = Convert.ToInt32(txt_Num1.Text) - Convert.ToInt32(txt_Num2.Text);
                        if (Ingreso == resultado)
                        {
                            Respuestas[Pregunta] = "Respuesta correcta";
                            Pregunta++;
                            Actualizar();
                        }
                        else
                        {
                            Respuestas[Pregunta] = "Respuesta incorrecta";
                            Pregunta++;
                            Actualizar();
                        }
                        break;
                }

            }
            catch
            {
                MessageBox.Show("Solo puedes ingresar numeros y no puedes dejar campos vacios" + salto + "No sea porfiado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Basico5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
