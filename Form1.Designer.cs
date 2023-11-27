namespace Practica_16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 48);
            label1.Name = "label1";
            label1.Size = new Size(267, 27);
            label1.TabIndex = 0;
            label1.Text = "Dado como un número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 91);
            label2.Name = "label2";
            label2.Size = new Size(304, 50);
            label2.TabIndex = 1;
            label2.Text = "determinar si es par o impar\r\ny divisible por 3";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 173);
            label3.Name = "label3";
            label3.Size = new Size(303, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingresar número cualquiera:\r\n";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(337, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 37);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(114, 237);
            button1.Name = "button1";
            button1.Size = new Size(166, 35);
            button1.TabIndex = 4;
            button1.Text = "Determinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(286, 237);
            button2.Name = "button2";
            button2.Size = new Size(166, 35);
            button2.TabIndex = 5;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(557, 363);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Par e Impar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}