namespace Tarea
{
    partial class Basico2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basico2));
            this.lbl_NumPregunta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_restultado = new System.Windows.Forms.TextBox();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.txt_operacion = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.btn_cambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NumPregunta
            // 
            this.lbl_NumPregunta.AutoSize = true;
            this.lbl_NumPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_NumPregunta.Location = new System.Drawing.Point(188, 10);
            this.lbl_NumPregunta.Name = "lbl_NumPregunta";
            this.lbl_NumPregunta.Size = new System.Drawing.Size(23, 25);
            this.lbl_NumPregunta.TabIndex = 16;
            this.lbl_NumPregunta.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(124, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "=";
            // 
            // txt_restultado
            // 
            this.txt_restultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txt_restultado.Location = new System.Drawing.Point(91, 144);
            this.txt_restultado.MaxLength = 2;
            this.txt_restultado.Multiline = true;
            this.txt_restultado.Name = "txt_restultado";
            this.txt_restultado.Size = new System.Drawing.Size(100, 54);
            this.txt_restultado.TabIndex = 13;
            this.txt_restultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.Location = new System.Drawing.Point(146, 203);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(126, 32);
            this.btn_ingreso.TabIndex = 9;
            this.btn_ingreso.Text = "Ingresar";
            this.btn_ingreso.UseVisualStyleBackColor = true;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // txt_operacion
            // 
            this.txt_operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operacion.Location = new System.Drawing.Point(121, 62);
            this.txt_operacion.Multiline = true;
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.ReadOnly = true;
            this.txt_operacion.Size = new System.Drawing.Size(45, 38);
            this.txt_operacion.TabIndex = 14;
            this.txt_operacion.Text = "+";
            this.txt_operacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txt_Num2.Location = new System.Drawing.Point(172, 47);
            this.txt_Num2.Multiline = true;
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.ReadOnly = true;
            this.txt_Num2.Size = new System.Drawing.Size(100, 54);
            this.txt_Num2.TabIndex = 11;
            this.txt_Num2.Text = "5";
            this.txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pregunta #";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1.Location = new System.Drawing.Point(12, 47);
            this.txt_Num1.Multiline = true;
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.ReadOnly = true;
            this.txt_Num1.Size = new System.Drawing.Size(103, 54);
            this.txt_Num1.TabIndex = 10;
            this.txt_Num1.Text = "45";
            this.txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cambio
            // 
            this.btn_cambio.Location = new System.Drawing.Point(12, 203);
            this.btn_cambio.Name = "btn_cambio";
            this.btn_cambio.Size = new System.Drawing.Size(126, 32);
            this.btn_cambio.TabIndex = 17;
            this.btn_cambio.Text = "Cambiar Pregunta";
            this.btn_cambio.UseVisualStyleBackColor = true;
            this.btn_cambio.Click += new System.EventHandler(this.btn_cambio_Click);
            // 
            // Basico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.btn_cambio);
            this.Controls.Add(this.lbl_NumPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_restultado);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.txt_operacion);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Num1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Basico2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basico2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Basico2_FormClosing_1);
            this.Load += new System.EventHandler(this.Basico2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NumPregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_restultado;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.TextBox txt_operacion;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.Button btn_cambio;
    }
}