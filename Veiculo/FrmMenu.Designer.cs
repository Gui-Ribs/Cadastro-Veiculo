namespace Veiculo
{
    partial class frmMenu
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
            this.btnCarro = new System.Windows.Forms.Button();
            this.brnSair = new System.Windows.Forms.Button();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.BackColor = System.Drawing.Color.Transparent;
            this.btnCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarro.Location = new System.Drawing.Point(246, 219);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(94, 47);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = false;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // brnSair
            // 
            this.brnSair.BackColor = System.Drawing.Color.Transparent;
            this.brnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnSair.ForeColor = System.Drawing.Color.Salmon;
            this.brnSair.Location = new System.Drawing.Point(516, 219);
            this.brnSair.Name = "brnSair";
            this.brnSair.Size = new System.Drawing.Size(94, 47);
            this.brnSair.TabIndex = 1;
            this.brnSair.Text = "Sair";
            this.brnSair.UseVisualStyleBackColor = false;
            this.brnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.BackColor = System.Drawing.Color.Transparent;
            this.btnCaminhao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaminhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminhao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaminhao.Location = new System.Drawing.Point(368, 219);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(94, 47);
            this.btnCaminhao.TabIndex = 2;
            this.btnCaminhao.Text = "Caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = false;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(899, 484);
            this.Controls.Add(this.btnCaminhao);
            this.Controls.Add(this.brnSair);
            this.Controls.Add(this.btnCarro);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button brnSair;
        private System.Windows.Forms.Button btnCaminhao;
    }
}

