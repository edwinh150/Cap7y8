namespace Cap7y8
{
    partial class Cap8e2Form
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
            this.JustificartextBox = new System.Windows.Forms.TextBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.IzradioButton = new System.Windows.Forms.RadioButton();
            this.DereradioButton = new System.Windows.Forms.RadioButton();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JustificartextBox
            // 
            this.JustificartextBox.Location = new System.Drawing.Point(51, 64);
            this.JustificartextBox.Name = "JustificartextBox";
            this.JustificartextBox.Size = new System.Drawing.Size(166, 20);
            this.JustificartextBox.TabIndex = 0;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(241, 64);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 1;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // IzradioButton
            // 
            this.IzradioButton.AutoSize = true;
            this.IzradioButton.Location = new System.Drawing.Point(51, 125);
            this.IzradioButton.Name = "IzradioButton";
            this.IzradioButton.Size = new System.Drawing.Size(68, 17);
            this.IzradioButton.TabIndex = 2;
            this.IzradioButton.TabStop = true;
            this.IzradioButton.Text = "Izquierda";
            this.IzradioButton.UseVisualStyleBackColor = true;
            // 
            // DereradioButton
            // 
            this.DereradioButton.AutoSize = true;
            this.DereradioButton.Location = new System.Drawing.Point(175, 125);
            this.DereradioButton.Name = "DereradioButton";
            this.DereradioButton.Size = new System.Drawing.Size(66, 17);
            this.DereradioButton.TabIndex = 2;
            this.DereradioButton.TabStop = true;
            this.DereradioButton.Text = "Derecha";
            this.DereradioButton.UseVisualStyleBackColor = true;
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Location = new System.Drawing.Point(51, 177);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(225, 121);
            this.ResultadolistBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Justificacion";
            // 
            // Cap8e2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.DereradioButton);
            this.Controls.Add(this.IzradioButton);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.JustificartextBox);
            this.Name = "Cap8e2Form";
            this.Text = "Cap8e2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JustificartextBox;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.RadioButton IzradioButton;
        private System.Windows.Forms.RadioButton DereradioButton;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.Label label1;
    }
}