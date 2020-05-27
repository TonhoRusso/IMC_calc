namespace IMC
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
            this.P = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(77, 46);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(100, 20);
            this.P.TabIndex = 0;
            this.P.Text = "Insira Peso";
            this.P.TextChanged += new System.EventHandler(this.P_TextChanged);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(77, 91);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 1;
            this.A.Text = "Insira Altura";
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.A);
            this.Controls.Add(this.P);
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox P;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Button button1;
    }
}

