
namespace Numero_Aleatorio_JR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtintentos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txrnumero = new System.Windows.Forms.TextBox();
            this.Adivinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adivina el número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intentos:";
            // 
            // txtintentos
            // 
            this.txtintentos.Location = new System.Drawing.Point(152, 79);
            this.txtintentos.Name = "txtintentos";
            this.txtintentos.ReadOnly = true;
            this.txtintentos.Size = new System.Drawing.Size(127, 35);
            this.txtintentos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número";
            // 
            // txrnumero
            // 
            this.txrnumero.Location = new System.Drawing.Point(152, 148);
            this.txrnumero.Name = "txrnumero";
            this.txrnumero.Size = new System.Drawing.Size(127, 35);
            this.txrnumero.TabIndex = 4;
            this.txrnumero.TextChanged += new System.EventHandler(this.txrnumero_TextChanged);
            // 
            // Adivinar
            // 
            this.Adivinar.Location = new System.Drawing.Point(62, 221);
            this.Adivinar.Name = "Adivinar";
            this.Adivinar.Size = new System.Drawing.Size(174, 58);
            this.Adivinar.TabIndex = 5;
            this.Adivinar.Text = "Adivinar";
            this.Adivinar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(333, 313);
            this.Controls.Add(this.Adivinar);
            this.Controls.Add(this.txrnumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtintentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Adivina el número";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtintentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txrnumero;
        private System.Windows.Forms.Button Adivinar;
    }
}

