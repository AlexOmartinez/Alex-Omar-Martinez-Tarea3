namespace Tarea3_AlexOmarMartinez.Forms
{
    partial class FormSuma
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrimerN = new System.Windows.Forms.TextBox();
            this.TxtSegundoN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTercerN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(164, 183);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(67, 32);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnSumar
            // 
            this.BtnSumar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSumar.Location = new System.Drawing.Point(18, 159);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(94, 47);
            this.BtnSumar.TabIndex = 3;
            this.BtnSumar.Text = "Sumar";
            this.BtnSumar.UseVisualStyleBackColor = true;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Primer Numero";
            // 
            // TxtPrimerN
            // 
            this.TxtPrimerN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrimerN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerN.Location = new System.Drawing.Point(131, 60);
            this.TxtPrimerN.Name = "TxtPrimerN";
            this.TxtPrimerN.Size = new System.Drawing.Size(100, 25);
            this.TxtPrimerN.TabIndex = 6;
            // 
            // TxtSegundoN
            // 
            this.TxtSegundoN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSegundoN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoN.Location = new System.Drawing.Point(131, 91);
            this.TxtSegundoN.Name = "TxtSegundoN";
            this.TxtSegundoN.Size = new System.Drawing.Size(100, 25);
            this.TxtSegundoN.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundo Numero";
            // 
            // TxtTercerN
            // 
            this.TxtTercerN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTercerN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTercerN.Location = new System.Drawing.Point(131, 122);
            this.TxtTercerN.Name = "TxtTercerN";
            this.TxtTercerN.Size = new System.Drawing.Size(100, 25);
            this.TxtTercerN.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tercer Numero";
            // 
            // FormSuma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(238, 218);
            this.ControlBox = false;
            this.Controls.Add(this.TxtTercerN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSegundoN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPrimerN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormSuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Suma de 3 Numeros";
            this.Load += new System.EventHandler(this.FormSuma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrimerN;
        private System.Windows.Forms.TextBox TxtSegundoN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTercerN;
        private System.Windows.Forms.Label label4;
    }
}