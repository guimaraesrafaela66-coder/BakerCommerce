namespace BakerCommerce
{
    partial class FormProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNomeCadstro = new System.Windows.Forms.Label();
            this.cmbNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.cmbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblCategoriaCadastrar = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.cmbPrecoEditar = new System.Windows.Forms.TextBox();
            this.cmbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.lblApagarDescricao = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblGerenciadordePreodutos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(84, 67);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(548, 227);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.cmbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadstro);
            this.grbCadastrar.Location = new System.Drawing.Point(66, 315);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(260, 185);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            this.grbCadastrar.Enter += new System.EventHandler(this.grbCadastrar_Enter);
            // 
            // lblNomeCadstro
            // 
            this.lblNomeCadstro.AutoSize = true;
            this.lblNomeCadstro.Location = new System.Drawing.Point(15, 26);
            this.lblNomeCadstro.Name = "lblNomeCadstro";
            this.lblNomeCadstro.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCadstro.TabIndex = 2;
            this.lblNomeCadstro.Text = "Nome";
            // 
            // cmbNomeCadastro
            // 
            this.cmbNomeCadastro.Location = new System.Drawing.Point(94, 19);
            this.cmbNomeCadastro.Name = "cmbNomeCadastro";
            this.cmbNomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.cmbNomeCadastro.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(15, 61);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoCadastro.TabIndex = 4;
            this.lblPrecoCadastro.Text = "Preço";
            // 
            // cmbPrecoCadastro
            // 
            this.cmbPrecoCadastro.Location = new System.Drawing.Point(94, 54);
            this.cmbPrecoCadastro.Name = "cmbPrecoCadastro";
            this.cmbPrecoCadastro.Size = new System.Drawing.Size(100, 20);
            this.cmbPrecoCadastro.TabIndex = 5;
            // 
            // lblCategoriaCadastrar
            // 
            this.lblCategoriaCadastrar.AutoSize = true;
            this.lblCategoriaCadastrar.Location = new System.Drawing.Point(6, 87);
            this.lblCategoriaCadastrar.Name = "lblCategoriaCadastrar";
            this.lblCategoriaCadastrar.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaCadastrar.TabIndex = 7;
            this.lblCategoriaCadastrar.Text = "Categoria";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(49, 127);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(154, 34);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.cmbPrecoEditar);
            this.grbEditar.Controls.Add(this.cmbNomeEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(372, 315);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(260, 185);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(49, 127);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(154, 34);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(6, 87);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaEditar.TabIndex = 7;
            this.lblCategoriaEditar.Text = "Categoria";
            // 
            // cmbPrecoEditar
            // 
            this.cmbPrecoEditar.Location = new System.Drawing.Point(94, 54);
            this.cmbPrecoEditar.Name = "cmbPrecoEditar";
            this.cmbPrecoEditar.Size = new System.Drawing.Size(100, 20);
            this.cmbPrecoEditar.TabIndex = 5;
            // 
            // cmbNomeEditar
            // 
            this.cmbNomeEditar.Location = new System.Drawing.Point(94, 19);
            this.cmbNomeEditar.Name = "cmbNomeEditar";
            this.cmbNomeEditar.Size = new System.Drawing.Size(100, 20);
            this.cmbNomeEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(15, 61);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoEditar.TabIndex = 4;
            this.lblPrecoEditar.Text = "Preço";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(15, 26);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(35, 13);
            this.lblNomeEditar.TabIndex = 2;
            this.lblNomeEditar.Text = "Nome";
            // 
            // lblApagarDescricao
            // 
            this.lblApagarDescricao.AutoSize = true;
            this.lblApagarDescricao.Location = new System.Drawing.Point(6, 45);
            this.lblApagarDescricao.Name = "lblApagarDescricao";
            this.lblApagarDescricao.Size = new System.Drawing.Size(170, 13);
            this.lblApagarDescricao.TabIndex = 0;
            this.lblApagarDescricao.Text = "Selecione um produto para apagar";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagarDescricao);
            this.grbApagar.Location = new System.Drawing.Point(27, 588);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(674, 84);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(541, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(110, 39);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lblGerenciadordePreodutos
            // 
            this.lblGerenciadordePreodutos.AutoSize = true;
            this.lblGerenciadordePreodutos.Font = new System.Drawing.Font("Futura Bk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciadordePreodutos.Location = new System.Drawing.Point(366, 12);
            this.lblGerenciadordePreodutos.Name = "lblGerenciadordePreodutos";
            this.lblGerenciadordePreodutos.Size = new System.Drawing.Size(307, 32);
            this.lblGerenciadordePreodutos.TabIndex = 4;
            this.lblGerenciadordePreodutos.Text = "Gerenciador de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.Pães;
            this.pictureBox1.Location = new System.Drawing.Point(688, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(73, 84);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaCadastro.TabIndex = 9;
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(94, 84);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaEditar.TabIndex = 9;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGerenciadordePreodutos);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.TextBox cmbPrecoCadastro;
        private System.Windows.Forms.TextBox cmbNomeCadastro;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.Label lblNomeCadstro;
        private System.Windows.Forms.Label lblCategoriaCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox cmbPrecoEditar;
        private System.Windows.Forms.TextBox cmbNomeEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.Label lblApagarDescricao;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblGerenciadordePreodutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
    }
}