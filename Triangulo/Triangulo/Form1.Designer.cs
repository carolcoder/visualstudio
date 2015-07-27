namespace Triangulo
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
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(86, 101);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 0;
            this.txtLado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.txtLado1.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(86, 128);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 1;
            this.txtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.txtLado2.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(86, 155);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 2;
            this.txtLado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.txtLado3.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(230, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(153, 242);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(154, 46);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 373);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Name = "Form1";
            this.Text = "Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResult;
    }
}

