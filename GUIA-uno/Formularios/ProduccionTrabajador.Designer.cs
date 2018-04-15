namespace GUIA_uno.Formularios
{
    partial class ProduccionTrabajador
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlunes = new System.Windows.Forms.TextBox();
            this.txtmartes = new System.Windows.Forms.TextBox();
            this.txtmiercoles = new System.Windows.Forms.TextBox();
            this.txtjueves = new System.Windows.Forms.TextBox();
            this.txtviernes = new System.Windows.Forms.TextBox();
            this.txtsabado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lunes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Martes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miercoles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jueves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Viernes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sabado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ingrese cantidad de bandejas del trabajador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calcularpromedio);
            // 
            // txtlunes
            // 
            this.txtlunes.Location = new System.Drawing.Point(52, 71);
            this.txtlunes.Name = "txtlunes";
            this.txtlunes.Size = new System.Drawing.Size(34, 20);
            this.txtlunes.TabIndex = 14;
            // 
            // txtmartes
            // 
            this.txtmartes.Location = new System.Drawing.Point(52, 108);
            this.txtmartes.Name = "txtmartes";
            this.txtmartes.Size = new System.Drawing.Size(34, 20);
            this.txtmartes.TabIndex = 15;
            // 
            // txtmiercoles
            // 
            this.txtmiercoles.Location = new System.Drawing.Point(52, 147);
            this.txtmiercoles.Name = "txtmiercoles";
            this.txtmiercoles.Size = new System.Drawing.Size(34, 20);
            this.txtmiercoles.TabIndex = 16;
            // 
            // txtjueves
            // 
            this.txtjueves.Location = new System.Drawing.Point(52, 186);
            this.txtjueves.Name = "txtjueves";
            this.txtjueves.Size = new System.Drawing.Size(34, 20);
            this.txtjueves.TabIndex = 17;
            // 
            // txtviernes
            // 
            this.txtviernes.Location = new System.Drawing.Point(52, 225);
            this.txtviernes.Name = "txtviernes";
            this.txtviernes.Size = new System.Drawing.Size(34, 20);
            this.txtviernes.TabIndex = 18;
            // 
            // txtsabado
            // 
            this.txtsabado.Location = new System.Drawing.Point(53, 261);
            this.txtsabado.Name = "txtsabado";
            this.txtsabado.Size = new System.Drawing.Size(34, 20);
            this.txtsabado.TabIndex = 19;
            // 
            // ProduccionTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.Controls.Add(this.txtsabado);
            this.Controls.Add(this.txtviernes);
            this.Controls.Add(this.txtjueves);
            this.Controls.Add(this.txtmiercoles);
            this.Controls.Add(this.txtmartes);
            this.Controls.Add(this.txtlunes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProduccionTrabajador";
            this.Text = "ProduccionTrabajador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtlunes;
        private System.Windows.Forms.TextBox txtmartes;
        private System.Windows.Forms.TextBox txtmiercoles;
        private System.Windows.Forms.TextBox txtjueves;
        private System.Windows.Forms.TextBox txtviernes;
        private System.Windows.Forms.TextBox txtsabado;
    }
}