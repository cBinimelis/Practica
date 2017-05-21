namespace Tarea
{
    partial class Basico1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basico1));
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.txt_restultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NumPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Num1
            // 
            this.txt_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1.Location = new System.Drawing.Point(12, 46);
            this.txt_Num1.Multiline = true;
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.ReadOnly = true;
            this.txt_Num1.Size = new System.Drawing.Size(103, 54);
            this.txt_Num1.TabIndex = 1;
            this.txt_Num1.Text = "45";
            this.txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregunta #";
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txt_Num2.Location = new System.Drawing.Point(172, 46);
            this.txt_Num2.Multiline = true;
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.ReadOnly = true;
            this.txt_Num2.Size = new System.Drawing.Size(100, 54);
            this.txt_Num2.TabIndex = 2;
            this.txt_Num2.Text = "5";
            this.txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(121, 61);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(45, 38);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "+";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.Location = new System.Drawing.Point(12, 203);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(260, 32);
            this.btn_ingreso.TabIndex = 0;
            this.btn_ingreso.Text = "Ingresar";
            this.btn_ingreso.UseVisualStyleBackColor = true;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // txt_restultado
            // 
            this.txt_restultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txt_restultado.Location = new System.Drawing.Point(91, 143);
            this.txt_restultado.MaxLength = 2;
            this.txt_restultado.Multiline = true;
            this.txt_restultado.Name = "txt_restultado";
            this.txt_restultado.Size = new System.Drawing.Size(100, 54);
            this.txt_restultado.TabIndex = 3;
            this.txt_restultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(124, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // lbl_NumPregunta
            // 
            this.lbl_NumPregunta.AutoSize = true;
            this.lbl_NumPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_NumPregunta.Location = new System.Drawing.Point(188, 9);
            this.lbl_NumPregunta.Name = "lbl_NumPregunta";
            this.lbl_NumPregunta.Size = new System.Drawing.Size(23, 25);
            this.lbl_NumPregunta.TabIndex = 8;
            this.lbl_NumPregunta.Text = "0";
            // 
            // Basico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.lbl_NumPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_restultado);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Num1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Basico1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1° Basico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Basico1_FormClosing);
            this.Load += new System.EventHandler(this.Basico1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.TextBox txt_restultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NumPregunta;
    }
}