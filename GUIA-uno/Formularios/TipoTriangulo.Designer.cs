namespace GUIA_uno.Formularios
{
    partial class TipoTriangulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtladoA = new System.Windows.Forms.TextBox();
            this.txtladoB = new System.Windows.Forms.TextBox();
            this.txtladoC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltriangulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado C";
            // 
            // txtladoA
            // 
            this.txtladoA.Location = new System.Drawing.Point(49, 39);
            this.txtladoA.Name = "txtladoA";
            this.txtladoA.Size = new System.Drawing.Size(100, 20);
            this.txtladoA.TabIndex = 3;
            // 
            // txtladoB
            // 
            this.txtladoB.Location = new System.Drawing.Point(49, 101);
            this.txtladoB.Name = "txtladoB";
            this.txtladoB.Size = new System.Drawing.Size(100, 20);
            this.txtladoB.TabIndex = 4;
            // 
            // txtladoC
            // 
            this.txtladoC.Location = new System.Drawing.Point(49, 172);
            this.txtladoC.Name = "txtladoC";
            this.txtladoC.Size = new System.Drawing.Size(100, 20);
            this.txtladoC.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tipo de Triangulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalcularTipoTriangulo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Es un triangulo :";
            // 
            // lbltriangulo
            // 
            this.lbltriangulo.AutoSize = true;
            this.lbltriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltriangulo.Location = new System.Drawing.Point(294, 92);
            this.lbltriangulo.Name = "lbltriangulo";
            this.lbltriangulo.Size = new System.Drawing.Size(0, 16);
            this.lbltriangulo.TabIndex = 8;
            // 
            // TipoTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 395);
            this.Controls.Add(this.lbltriangulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtladoC);
            this.Controls.Add(this.txtladoB);
            this.Controls.Add(this.txtladoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TipoTriangulo";
            this.Text = "TipoTriangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtladoA;
        private System.Windows.Forms.TextBox txtladoB;
        private System.Windows.Forms.TextBox txtladoC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltriangulo;
    }
}