namespace armandoStein
{
    partial class Form1
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
            this.numeroClick = new System.Windows.Forms.Label();
            this.contadorClick = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.somar = new System.Windows.Forms.Button();
            this.mensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numeroClick
            // 
            this.numeroClick.AutoSize = true;
            this.numeroClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroClick.Location = new System.Drawing.Point(131, 50);
            this.numeroClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeroClick.Name = "numeroClick";
            this.numeroClick.Size = new System.Drawing.Size(310, 39);
            this.numeroClick.TabIndex = 0;
            this.numeroClick.Text = "Número de cliques:";
            // 
            // contadorClick
            // 
            this.contadorClick.AutoSize = true;
            this.contadorClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorClick.Location = new System.Drawing.Point(468, 50);
            this.contadorClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorClick.Name = "contadorClick";
            this.contadorClick.Size = new System.Drawing.Size(36, 39);
            this.contadorClick.TabIndex = 1;
            this.contadorClick.Text = "0";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(335, 236);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(199, 46);
            this.reset.TabIndex = 9;
            this.reset.Text = "ZERAR";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // somar
            // 
            this.somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.Location = new System.Drawing.Point(97, 236);
            this.somar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(199, 46);
            this.somar.TabIndex = 10;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // mensagem
            // 
            this.mensagem.Enabled = false;
            this.mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem.Location = new System.Drawing.Point(13, 147);
            this.mensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mensagem.Name = "mensagem";
            this.mensagem.Size = new System.Drawing.Size(565, 46);
            this.mensagem.TabIndex = 12;
            this.mensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 410);
            this.Controls.Add(this.mensagem);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.contadorClick);
            this.Controls.Add(this.numeroClick);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroClick;
        private System.Windows.Forms.Label contadorClick;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.TextBox mensagem;
    }
}

