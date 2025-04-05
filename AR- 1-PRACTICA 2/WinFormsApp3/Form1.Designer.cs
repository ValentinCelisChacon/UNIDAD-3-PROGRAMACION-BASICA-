namespace WinFormsApp3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 40);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "ESCRIBE UN NUMERO  ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 86);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 1;
            label2.Text = "ESCRIBE UN NUMERO  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 127);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 2;
            label3.Text = "ESCRIBE UN NUMERO  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 168);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 3;
            label4.Text = "ESCRIBE UN NUMERO  ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(298, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 236);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 8;
            label5.Text = "N1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 236);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 9;
            label6.Text = "N2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 236);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 10;
            label7.Text = "N3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(305, 236);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 11;
            label8.Text = "N4";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(493, 118);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "INVERTIR ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(493, 168);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}
