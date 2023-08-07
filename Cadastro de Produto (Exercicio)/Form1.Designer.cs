namespace Cadastro_de_Produto__Exercicio_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.tb_PrecoDeAquisicao = new System.Windows.Forms.TextBox();
            this.tb_ValorDeVenda = new System.Windows.Forms.TextBox();
            this.tb_Descricao = new System.Windows.Forms.TextBox();
            this.tb_Lucro = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço de Aquisição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lucro %.:";
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(206, 213);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 6;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(326, 213);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(450, 213);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(181, 83);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_Codigo.TabIndex = 9;
            // 
            // tb_PrecoDeAquisicao
            // 
            this.tb_PrecoDeAquisicao.Location = new System.Drawing.Point(181, 123);
            this.tb_PrecoDeAquisicao.Name = "tb_PrecoDeAquisicao";
            this.tb_PrecoDeAquisicao.Size = new System.Drawing.Size(100, 20);
            this.tb_PrecoDeAquisicao.TabIndex = 10;
            // 
            // tb_ValorDeVenda
            // 
            this.tb_ValorDeVenda.Enabled = false;
            this.tb_ValorDeVenda.Location = new System.Drawing.Point(181, 159);
            this.tb_ValorDeVenda.Name = "tb_ValorDeVenda";
            this.tb_ValorDeVenda.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorDeVenda.TabIndex = 11;
            this.tb_ValorDeVenda.TextChanged += new System.EventHandler(this.tb_ValorDeVenda_TextChanged);
            // 
            // tb_Descricao
            // 
            this.tb_Descricao.Location = new System.Drawing.Point(495, 96);
            this.tb_Descricao.Name = "tb_Descricao";
            this.tb_Descricao.Size = new System.Drawing.Size(100, 20);
            this.tb_Descricao.TabIndex = 12;
            // 
            // tb_Lucro
            // 
            this.tb_Lucro.Location = new System.Drawing.Point(495, 145);
            this.tb_Lucro.Name = "tb_Lucro";
            this.tb_Lucro.Size = new System.Drawing.Size(100, 20);
            this.tb_Lucro.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-40, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 210);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_Lucro);
            this.Controls.Add(this.tb_Descricao);
            this.Controls.Add(this.tb_ValorDeVenda);
            this.Controls.Add(this.tb_PrecoDeAquisicao);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.TextBox tb_PrecoDeAquisicao;
        private System.Windows.Forms.TextBox tb_ValorDeVenda;
        private System.Windows.Forms.TextBox tb_Descricao;
        private System.Windows.Forms.TextBox tb_Lucro;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

