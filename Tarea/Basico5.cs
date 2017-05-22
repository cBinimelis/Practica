using System;
using System.Collections;
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
            Actualizar();
            TiempoDeCambio.Interval = 15000;
            TiempoDePrueba.Interval = 12000;
            TiempoDeCambio.Tick += new EventHandler(TiempoCumplido);
            TiempoDePrueba.Tick += new EventHandler(FinDeTiempo);
            TiempoDePrueba.Start();
        }


        String salto = Environment.NewLine;
        Random Ran = new Random();
        int Ingreso;
        int Pregunta = 0;
        int Operacion;
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
            for (int i = 0; i < Respuestas.Count; i++)
            {
                Mensaje += "Pregunta #" + (i + 1) + " :" + Respuestas[i].ToString() + "." + salto;
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
                    //Suma
                    case 1:
                        resultado = Convert.ToInt32(txt_Num1.Text) + Convert.ToInt32(txt_Num2.Text);
                        if (Ingreso == resultado)
                        {
                            Respuestas.Add("Respuesta correcta");
                            Pregunta++;
                            Actualizar();
                        }
                        else
                        {
                            Respuestas.Add("Respuesta incorrecta");
                            Pregunta++;
                            Actualizar();
                        }
                        break;
                    //Resta
                    case 2:
                        resultado = Convert.ToInt32(txt_Num1.Text) - Convert.ToInt32(txt_Num2.Text);
                        if (Ingreso == resultado)
                        {
                            Respuestas.Add("Respuesta correcta");
                            Pregunta++;
                            Actualizar();
                        }
                        else
                        {
                            Respuestas.Add("Respuesta incorrecta");
                            Pregunta++;
                            Actualizar();
                        }
                        break;
                    //Multiplicacion
                    case 3:
                        resultado = Convert.ToInt32(txt_Num1.Text) * Convert.ToInt32(txt_Num2.Text);
                        if (Ingreso == resultado)
                        {
                            Respuestas.Add("Respuesta correcta");
                            Pregunta++;
                            Actualizar();
                        }
                        else
                        {
                            Respuestas.Add("Respuesta incorrecta");
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

        private void btn_cambio_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
