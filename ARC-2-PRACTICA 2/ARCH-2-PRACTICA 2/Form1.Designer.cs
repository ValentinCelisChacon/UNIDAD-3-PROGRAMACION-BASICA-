namespace ARCH_2_PRACTICA_2
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
            button1 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(610, 337);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 13;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Coral;
            listBox1.Font = new Font("SolidWorks GDT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(317, 170);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(158, 184);
            listBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 255);
            textBox2.Location = new Point(560, 143);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SolidWorks GDT", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(460, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(347, 20);
            label3.TabIndex = 10;
            label3.Text = "Limite maximo de la Tabla de multiplicar";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 255);
            textBox1.Location = new Point(91, 143);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(370, 20);
            label2.TabIndex = 8;
            label2.Text = "Introduce el valor de la Tabla de multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 24);
            label1.TabIndex = 7;
            label1.Text = "Tabla de multiplicar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
