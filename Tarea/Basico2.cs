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
    public partial class Basico2 : Form
    {
        System.Windows.Forms.Timer TiempoDeCambio = new System.Windows.Forms.Timer();
        public Basico2()
        {
            InitializeComponent();
        }

        String salto = Environment.NewLine;
        Random Ran = new Random();
        int Ingreso;
        int Pregunta = 0;
        int Operacion;
        String[] Respuestas = new String[10];
        private void Basico2_Load(object sender, EventArgs e)
        {
            Actualizar();
            TiempoDeCambio.Interval = 15000;
            TiempoDeCambio.Tick += new EventHandler(TiempoCumplido);
        }

        private void TiempoCumplido(object sender, EventArgs e)
        {
            btn_cambio.Hide();
            TiempoDeCambio.Stop();
        }

        protected void Elegir()
        {
            try
            {
                btn_cambio.Show();
                TiempoDeCambio.Start();
                Operacion = Ran.Next(1, 3);
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
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido configurar ");
            }
        }

        private void Actualizar()
        {
            if (Pregunta < 10)
            {
                Elegir();
                txt_restultado.Text = "";
                lbl_NumPregunta.Text = Convert.ToString(Pregunta + 1);
            }
            else
            {
                MuestraResultados();
            }
        }

        private void MuestraResultados()
        {
            MessageBox.Show("Respuestas" + salto +
                "Respuesta #1 =" + Respuestas[0] + salto +
                "Respuesta #2 =" + Respuestas[1] + salto +
                "Respuesta #3 =" + Respuestas[2] + salto +
                "Respuesta #4 =" + Respuestas[3] + salto +
                "Respuesta #5 =" + Respuestas[4] + salto +
                "Respuesta #6 =" + Respuestas[5] + salto +
                "Respuesta #7 =" + Respuestas[6] + salto +
                "Respuesta #8 =" + Respuestas[7] + salto +
                "Respuesta #9 =" + Respuestas[8] + salto +
                "Respuesta #10 =" + Respuestas[9], "Resultados Finales",
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
                }

            }
            catch
            {
                MessageBox.Show("Solo puedes ingresar numeros y no puedes dejar campos vacios" + salto + "No sea porfiado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Basico2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btn_cambio_Click(object sender, EventArgs e)
        {
            Elegir();
        }
    }
}
