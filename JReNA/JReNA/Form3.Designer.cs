
namespace JReNA
{
    partial class frmcelsius
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtfahrenheit = new System.Windows.Forms.TextBox();
            this.lblfahrenheit = new System.Windows.Forms.Label();
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.lblcelsius = new System.Windows.Forms.Label();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnrepita = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(520, 360);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(108, 35);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(347, 360);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(108, 35);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtfahrenheit
            // 
            this.txtfahrenheit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfahrenheit.Location = new System.Drawing.Point(332, 95);
            this.txtfahrenheit.Multiline = true;
            this.txtfahrenheit.Name = "txtfahrenheit";
            this.txtfahrenheit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtfahrenheit.Size = new System.Drawing.Size(313, 88);
            this.txtfahrenheit.TabIndex = 15;
            // 
            // lblfahrenheit
            // 
            this.lblfahrenheit.AutoSize = true;
            this.lblfahrenheit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfahrenheit.Location = new System.Drawing.Point(143, 95);
            this.lblfahrenheit.Name = "lblfahrenheit";
            this.lblfahrenheit.Size = new System.Drawing.Size(161, 16);
            this.lblfahrenheit.TabIndex = 14;
            this.lblfahrenheit.Text = "Em graus Fahrenheit é:";
            // 
            // txtcelsius
            // 
            this.txtcelsius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelsius.Location = new System.Drawing.Point(332, 48);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(313, 23);
            this.txtcelsius.TabIndex = 13;
            // 
            // lblcelsius
            // 
            this.lblcelsius.AutoSize = true;
            this.lblcelsius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelsius.Location = new System.Drawing.Point(39, 46);
            this.lblcelsius.Name = "lblcelsius";
            this.lblcelsius.Size = new System.Drawing.Size(265, 16);
            this.lblcelsius.TabIndex = 12;
            this.lblcelsius.Text = "Digite a temperatura em graus Celsius:";
            // 
            // btnpara
            // 
            this.btnpara.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpara.Location = new System.Drawing.Point(96, 261);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(172, 35);
            this.btnpara.TabIndex = 11;
            this.btnpara.Text = "Para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnrepita
            // 
            this.btnrepita.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepita.Location = new System.Drawing.Point(96, 202);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(172, 35);
            this.btnrepita.TabIndex = 10;
            this.btnrepita.Text = "Repita";
            this.btnrepita.UseVisualStyleBackColor = true;
            this.btnrepita.Click += new System.EventHandler(this.btnrepita_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenquanto.Location = new System.Drawing.Point(96, 139);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(172, 35);
            this.btnenquanto.TabIndex = 9;
            this.btnenquanto.Text = "Enquanto";
            this.btnenquanto.UseVisualStyleBackColor = true;
            this.btnenquanto.Click += new System.EventHandler(this.btnenquanto_Click);
            // 
            // frmcelsius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtfahrenheit);
            this.Controls.Add(this.lblfahrenheit);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.lblcelsius);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.btnenquanto);
            this.Name = "frmcelsius";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 12";
            this.Load += new System.EventHandler(this.frmcelsius_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtfahrenheit;
        private System.Windows.Forms.Label lblfahrenheit;
        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.Label lblcelsius;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.Button btnenquanto;
    }
}