namespace GUIA_uno.Formularios
{
    partial class UnidadesDecenas
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
            this.txtentero = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblentero = new System.Windows.Forms.Label();
            this.lbldecenas = new System.Windows.Forms.Label();
            this.lblunidades = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar número  entero de dos dígitos ";
            // 
            // txtentero
            // 
            this.txtentero.Location = new System.Drawing.Point(91, 46);
            this.txtentero.Name = "txtentero";
            this.txtentero.Size = new System.Drawing.Size(87, 20);
            this.txtentero.TabIndex = 1;
           
            this.txtentero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mostrarUnidadesYdecenas);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblunidades);
            this.panel1.Controls.Add(this.lbldecenas);
            this.panel1.Controls.Add(this.lblentero);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 184);
            this.panel1.TabIndex = 2;
            // 
            // lblentero
            // 
            this.lblentero.AutoSize = true;
            this.lblentero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentero.Location = new System.Drawing.Point(18, 18);
            this.lblentero.Name = "lblentero";
            this.lblentero.Size = new System.Drawing.Size(0, 16);
            this.lblentero.TabIndex = 0;
            // 
            // lbldecenas
            // 
            this.lbldecenas.AutoSize = true;
            this.lbldecenas.Location = new System.Drawing.Point(76, 20);
            this.lbldecenas.Name = "lbldecenas";
            this.lbldecenas.Size = new System.Drawing.Size(0, 13);
            this.lbldecenas.TabIndex = 1;
            // 
            // lblunidades
            // 
            this.lblunidades.AutoSize = true;
            this.lblunidades.Location = new System.Drawing.Point(161, 21);
            this.lblunidades.Name = "lblunidades";
            this.lblunidades.Size = new System.Drawing.Size(0, 13);
            this.lblunidades.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DECENA(S)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(161, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UNIDAD (ES)";
            // 
            // UnidadesDecenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtentero);
            this.Controls.Add(this.label1);
            this.Name = "UnidadesDecenas";
            this.Text = "UnidadesDecenas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtentero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblunidades;
        private System.Windows.Forms.Label lbldecenas;
        private System.Windows.Forms.Label lblentero;
    }
}