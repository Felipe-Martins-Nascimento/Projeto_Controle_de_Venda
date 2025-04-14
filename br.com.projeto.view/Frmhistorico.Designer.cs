namespace projeto__controles_de_venda.br.com.projeto.view
{
    partial class Frmhistorico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.dtfim = new System.Windows.Forms.DateTimePicker();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabelahistorico = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 83);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisar);
            this.groupBox1.Controls.Add(this.dtfim);
            this.groupBox1.Controls.Add(this.dtinicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(648, 31);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(147, 38);
            this.btnpesquisar.TabIndex = 24;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dtfim
            // 
            this.dtfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfim.Location = new System.Drawing.Point(442, 35);
            this.dtfim.Name = "dtfim";
            this.dtfim.Size = new System.Drawing.Size(200, 26);
            this.dtfim.TabIndex = 23;
            // 
            // dtinicio
            // 
            this.dtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(104, 35);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(225, 26);
            this.dtinicio.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(363, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data fim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(20, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data inicio:";
            // 
            // tabelahistorico
            // 
            this.tabelahistorico.AllowUserToAddRows = false;
            this.tabelahistorico.AllowUserToDeleteRows = false;
            this.tabelahistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelahistorico.Location = new System.Drawing.Point(13, 199);
            this.tabelahistorico.Name = "tabelahistorico";
            this.tabelahistorico.ReadOnly = true;
            this.tabelahistorico.Size = new System.Drawing.Size(824, 239);
            this.tabelahistorico.TabIndex = 5;
            this.tabelahistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelahistorico_CellClick);
            // 
            // Frmhistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.tabelahistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmhistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de vendas";
            this.Load += new System.EventHandler(this.Frmhistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelahistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtfim;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tabelahistorico;
        private System.Windows.Forms.Button btnpesquisar;
    }
}