namespace GUIA_uno.Formularios
{
    partial class HermanoMayor
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
            this.txtnomh1 = new System.Windows.Forms.TextBox();
            this.txtnomh2 = new System.Windows.Forms.TextBox();
            this.txtedah1 = new System.Windows.Forms.TextBox();
            this.txtedah2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre hermano 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad hermano 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre hermano 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad hermano 2";
            // 
            // txtnomh1
            // 
            this.txtnomh1.Location = new System.Drawing.Point(29, 47);
            this.txtnomh1.Name = "txtnomh1";
            this.txtnomh1.Size = new System.Drawing.Size(167, 20);
            this.txtnomh1.TabIndex = 4;
            // 
            // txtnomh2
            // 
            this.txtnomh2.Location = new System.Drawing.Point(29, 142);
            this.txtnomh2.Name = "txtnomh2";
            this.txtnomh2.Size = new System.Drawing.Size(167, 20);
            this.txtnomh2.TabIndex = 5;
            // 
            // txtedah1
            // 
            this.txtedah1.Location = new System.Drawing.Point(29, 92);
            this.txtedah1.Name = "txtedah1";
            this.txtedah1.Size = new System.Drawing.Size(72, 20);
            this.txtedah1.TabIndex = 6;
            // 
            // txtedah2
            // 
            this.txtedah2.Location = new System.Drawing.Point(29, 193);
            this.txtedah2.Name = "txtedah2";
            this.txtedah2.Size = new System.Drawing.Size(72, 20);
            this.txtedah2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calcular);
            // 
            // HermanoMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtedah2);
            this.Controls.Add(this.txtedah1);
            this.Controls.Add(this.txtnomh2);
            this.Controls.Add(this.txtnomh1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HermanoMayor";
            this.Text = "HermanoMayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomh1;
        private System.Windows.Forms.TextBox txtnomh2;
        private System.Windows.Forms.TextBox txtedah1;
        private System.Windows.Forms.TextBox txtedah2;
        private System.Windows.Forms.Button button1;
    }
}