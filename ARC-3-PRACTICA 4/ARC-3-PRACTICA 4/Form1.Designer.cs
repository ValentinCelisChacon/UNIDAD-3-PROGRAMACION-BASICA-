namespace ARC_3_PRACTICA_4
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
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(253, 224);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(98, 39);
            button2.TabIndex = 13;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(239, 279);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 28);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(253, 168);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 28);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(123, 224);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(98, 39);
            button1.TabIndex = 10;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 281);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 9;
            label3.Text = "Nuevo sueldo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 171);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 8;
            label2.Text = "Ingrese su sueldo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(318, 84);
            label1.TabIndex = 7;
            label1.Text = "Dado como dato el sueldo de un trabajador,\r\nel programa aplica un aumento de 15% si el\r\nsueldo es menor de 400,000 y si es mayor,\r\nse aumenta 8%.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
