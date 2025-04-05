namespace AR__1_PRACTICA_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            etiqueta = new Label();
            Resultado = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            valor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // etiqueta
            // 
            etiqueta.AutoSize = true;
            etiqueta.Location = new Point(480, 299);
            etiqueta.Margin = new Padding(2, 0, 2, 0);
            etiqueta.Name = "etiqueta";
            etiqueta.Size = new Size(50, 20);
            etiqueta.TabIndex = 23;
            etiqueta.Text = "label7";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(384, 292);
            Resultado.Margin = new Padding(2);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(72, 27);
            Resultado.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 298);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(148, 298);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(224, 20);
            label5.TabIndex = 20;
            label5.Text = "Equivalente en grados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 252);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 19;
            label4.Text = "Resultado en grados";
            // 
            // button3
            // 
            button3.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(495, 193);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(125, 27);
            button3.TabIndex = 18;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(311, 193);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(144, 27);
            button2.TabIndex = 17;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(145, 193);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(125, 27);
            button1.TabIndex = 16;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 139);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 20);
            label3.TabIndex = 15;
            label3.Text = "Opciones de conversion";
            // 
            // valor
            // 
            valor.Location = new Point(384, 85);
            valor.Margin = new Padding(2);
            valor.Name = "valor";
            valor.Size = new Size(146, 27);
            valor.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 13;
            label2.Text = "Ingresa el valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 12;
            label1.Text = "Datos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(etiqueta);
            Controls.Add(Resultado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiqueta;
        private TextBox Resultado;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox valor;
        private Label label2;
        private Label label1;
    }
}
