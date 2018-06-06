namespace calculator
{
    partial class Form1
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
            this.textBox1Num1 = new System.Windows.Forms.TextBox();
            this.textBox2Num2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1Num1
            // 
            this.textBox1Num1.Location = new System.Drawing.Point(32, 95);
            this.textBox1Num1.Name = "textBox1Num1";
            this.textBox1Num1.Size = new System.Drawing.Size(132, 20);
            this.textBox1Num1.TabIndex = 0;
            // 
            // textBox2Num2
            // 
            this.textBox2Num2.Location = new System.Drawing.Point(32, 177);
            this.textBox2Num2.Name = "textBox2Num2";
            this.textBox2Num2.Size = new System.Drawing.Size(132, 20);
            this.textBox2Num2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SOMAR",
            "DIMINUIR",
            "DIVIDIR",
            "MULTIPLICAR"});
            this.comboBox1.Location = new System.Drawing.Point(32, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Selecione a Operação";
            // 
            // button1Calcular
            // 
            this.button1Calcular.Location = new System.Drawing.Point(60, 220);
            this.button1Calcular.Name = "button1Calcular";
            this.button1Calcular.Size = new System.Drawing.Size(75, 23);
            this.button1Calcular.TabIndex = 3;
            this.button1Calcular.Text = "Calcular";
            this.button1Calcular.UseVisualStyleBackColor = true;
            this.button1Calcular.Click += new System.EventHandler(this.button1Calcular_Click);
            this.button1Calcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1Calcular_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Calcular);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2Num2);
            this.Controls.Add(this.textBox1Num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Num1;
        private System.Windows.Forms.TextBox textBox2Num2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1Calcular;
        private System.Windows.Forms.Label label1;
    }
}

