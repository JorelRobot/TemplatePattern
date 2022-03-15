namespace AppLibreria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViaTel = new System.Windows.Forms.Button();
            this.btnPresencial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(250, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venta de Libros ";
            // 
            // btnViaTel
            // 
            this.btnViaTel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnViaTel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViaTel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViaTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViaTel.Location = new System.Drawing.Point(144, 202);
            this.btnViaTel.Name = "btnViaTel";
            this.btnViaTel.Size = new System.Drawing.Size(220, 83);
            this.btnViaTel.TabIndex = 2;
            this.btnViaTel.Text = "Via Telefonica";
            this.btnViaTel.UseVisualStyleBackColor = false;
            this.btnViaTel.Click += new System.EventHandler(this.btnViaTel_Click);
            // 
            // btnPresencial
            // 
            this.btnPresencial.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPresencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresencial.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPresencial.Location = new System.Drawing.Point(453, 202);
            this.btnPresencial.Name = "btnPresencial";
            this.btnPresencial.Size = new System.Drawing.Size(220, 83);
            this.btnPresencial.TabIndex = 3;
            this.btnPresencial.Text = "Presencial";
            this.btnPresencial.UseVisualStyleBackColor = false;
            this.btnPresencial.Click += new System.EventHandler(this.btnPresencial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPresencial);
            this.Controls.Add(this.btnViaTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViaTel;
        private System.Windows.Forms.Button btnPresencial;
    }
}

