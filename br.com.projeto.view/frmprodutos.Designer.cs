namespace projeto__controles_de_venda.br.com.projeto.view
{
    partial class frmprodutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabprodutos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaproduto = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabprodutos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 83);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de produtos";
            // 
            // tabprodutos
            // 
            this.tabprodutos.Controls.Add(this.tabPage1);
            this.tabprodutos.Controls.Add(this.tabPage2);
            this.tabprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabprodutos.Location = new System.Drawing.Point(3, 89);
            this.tabprodutos.Name = "tabprodutos";
            this.tabprodutos.SelectedIndex = 0;
            this.tabprodutos.Size = new System.Drawing.Size(826, 334);
            this.tabprodutos.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbfornecedor);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtpreco);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtqtd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtdesc);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(120, 130);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(261, 28);
            this.cbfornecedor.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(19, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fornecedor:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(574, 62);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(139, 26);
            this.txtpreco.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(488, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Preço (R$):";
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(120, 94);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(112, 26);
            this.txtqtd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qtd estroque:";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(120, 56);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(341, 26);
            this.txtdesc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(30, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(120, 27);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(51, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaproduto);
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaproduto
            // 
            this.tabelaproduto.AllowUserToAddRows = false;
            this.tabelaproduto.AllowUserToDeleteRows = false;
            this.tabelaproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaproduto.Location = new System.Drawing.Point(6, 76);
            this.tabelaproduto.Name = "tabelaproduto";
            this.tabelaproduto.ReadOnly = true;
            this.tabelaproduto.Size = new System.Drawing.Size(806, 219);
            this.tabelaproduto.TabIndex = 7;
            this.tabelaproduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaproduto_CellClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(441, 13);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(98, 45);
            this.btnpesquisar.TabIndex = 6;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(84, 25);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(341, 26);
            this.txtpesquisa.TabIndex = 5;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnexcluir.Location = new System.Drawing.Point(416, 425);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(87, 38);
            this.btnexcluir.TabIndex = 9;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btneditar.Location = new System.Drawing.Point(509, 425);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(87, 38);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalvar.Location = new System.Drawing.Point(324, 425);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(87, 38);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(233, 425);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(85, 38);
            this.btnnovo.TabIndex = 6;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 480);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabprodutos);
            this.Controls.Add(this.panel1);
            this.Name = "frmprodutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.frmprodutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabprodutos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaproduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabelaproduto;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TabControl tabprodutos;
        public System.Windows.Forms.TabPage tabPage2;
    }
}