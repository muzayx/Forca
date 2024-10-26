namespace JogoDaForca
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a palavra aqui:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPalavra
            // 
            this.txtPalavra.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPalavra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(69, 88);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(394, 39);
            this.txtPalavra.TabIndex = 1;
            this.txtPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPalavra.TextChanged += new System.EventHandler(this.txtPalavra_TextChanged);
            this.txtPalavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe uma dica sobre a palavra:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDica
            // 
            this.txtDica.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDica.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDica.Location = new System.Drawing.Point(69, 274);
            this.txtDica.Name = "txtDica";
            this.txtDica.Size = new System.Drawing.Size(394, 39);
            this.txtDica.TabIndex = 3;
            this.txtDica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDica.TextChanged += new System.EventHandler(this.txtDica_TextChanged);
            // 
            // btnJogar
            // 
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(194, 347);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(127, 49);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(169, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Joguinho da forca desenvolvido por: Gabriel e Adrielen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Essa dica ficará visível para os jogadores na tela)";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtDica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 480);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inico do joguinho da forca do ga e da dri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDica;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

