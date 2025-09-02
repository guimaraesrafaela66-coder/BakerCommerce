namespace BakerCommerce
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuário = new System.Windows.Forms.Button();
            this.lblMenuPrincipalPadarosa = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComandas
            // 
            this.btnComandas.Location = new System.Drawing.Point(99, 174);
            this.btnComandas.Margin = new System.Windows.Forms.Padding(8);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(242, 85);
            this.btnComandas.TabIndex = 0;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = true;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(357, 174);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(8);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(234, 85);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Location = new System.Drawing.Point(107, 288);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(8);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(484, 54);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUsuário
            // 
            this.btnUsuário.Location = new System.Drawing.Point(107, 348);
            this.btnUsuário.Margin = new System.Windows.Forms.Padding(8);
            this.btnUsuário.Name = "btnUsuário";
            this.btnUsuário.Size = new System.Drawing.Size(484, 54);
            this.btnUsuário.TabIndex = 3;
            this.btnUsuário.Text = "Usuário";
            this.btnUsuário.UseVisualStyleBackColor = true;
            this.btnUsuário.Click += new System.EventHandler(this.btnUsuário_Click);
            // 
            // lblMenuPrincipalPadarosa
            // 
            this.lblMenuPrincipalPadarosa.AutoSize = true;
            this.lblMenuPrincipalPadarosa.Font = new System.Drawing.Font("Futura Bk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipalPadarosa.Location = new System.Drawing.Point(192, 35);
            this.lblMenuPrincipalPadarosa.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMenuPrincipalPadarosa.Name = "lblMenuPrincipalPadarosa";
            this.lblMenuPrincipalPadarosa.Size = new System.Drawing.Size(333, 32);
            this.lblMenuPrincipalPadarosa.TabIndex = 4;
            this.lblMenuPrincipalPadarosa.Text = "Menu Principal :: Padarosa";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.Location = new System.Drawing.Point(80, 93);
            this.lblDescrição.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(545, 25);
            this.lblDescrição.TabIndex = 5;
            this.lblDescrição.Text = "Olá Adminiistrador de Souza! Escolha uma opção abaixo:";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakerCommerce.Properties.Resources.Pães;
            this.ClientSize = new System.Drawing.Size(672, 446);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.lblMenuPrincipalPadarosa);
            this.Controls.Add(this.btnUsuário);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuário;
        private System.Windows.Forms.Label lblMenuPrincipalPadarosa;
        private System.Windows.Forms.Label lblDescrição;
    }
}