namespace Cap7y8
{
    partial class Cap8e4Form
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
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(37, 117);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(170, 20);
            this.Numero2textBox.TabIndex = 0;
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(37, 70);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(170, 20);
            this.Numero1textBox.TabIndex = 0;
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(86, 197);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(170, 20);
            this.ResultadotextBox.TabIndex = 0;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(235, 88);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(90, 26);
            this.Mostrarbutton.TabIndex = 1;
            this.Mostrarbutton.Text = "Sumar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "segundo Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma de numeros";
            // 
            // Cap8e4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.Numero2textBox);
            this.Name = "Cap8e4Form";
            this.Text = "Cap8e4Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}