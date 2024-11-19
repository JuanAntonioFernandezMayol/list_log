namespace list_log
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(400, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 35);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(621, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 35);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Usuario" });
            comboBox1.Location = new Point(36, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 38);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Tipo de usuario";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(36, 12);
            button1.Name = "button1";
            button1.Size = new Size(171, 78);
            button1.TabIndex = 4;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(564, 24);
            button2.Name = "button2";
            button2.Size = new Size(182, 66);
            button2.TabIndex = 5;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(211, 243);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 184);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Location = new Point(506, 243);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(265, 184);
            listBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 109);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 109);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 210);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 10;
            label3.Text = "Administradores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 210);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 11;
            label4.Text = "Usuarios";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
