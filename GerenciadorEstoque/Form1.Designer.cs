namespace GerenciadorEstoque {
    partial class Home {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.painelBotoes = new System.Windows.Forms.Panel();
            this.painelVermelhoAmarelo = new System.Windows.Forms.Panel();
            this.painelLogo = new System.Windows.Forms.Panel();
            this.Nome = new System.Windows.Forms.Label();
            this.botaoHome = new System.Windows.Forms.Button();
            this.botaoListaProdutos = new System.Windows.Forms.Button();
            this.botaoVenda = new System.Windows.Forms.Button();
            this.botaoCompra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.painelBotoes.SuspendLayout();
            this.painelVermelhoAmarelo.SuspendLayout();
            this.painelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // painelBotoes
            // 
            this.painelBotoes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.painelBotoes.BackColor = System.Drawing.Color.LightBlue;
            this.painelBotoes.Controls.Add(this.button2);
            this.painelBotoes.Controls.Add(this.button1);
            this.painelBotoes.Controls.Add(this.botaoCompra);
            this.painelBotoes.Controls.Add(this.botaoVenda);
            this.painelBotoes.Controls.Add(this.botaoListaProdutos);
            this.painelBotoes.Controls.Add(this.botaoHome);
            this.painelBotoes.Controls.Add(this.painelLogo);
            this.painelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelBotoes.Location = new System.Drawing.Point(0, 0);
            this.painelBotoes.Name = "painelBotoes";
            this.painelBotoes.Size = new System.Drawing.Size(245, 618);
            this.painelBotoes.TabIndex = 0;
            // 
            // painelVermelhoAmarelo
            // 
            this.painelVermelhoAmarelo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.painelVermelhoAmarelo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.painelVermelhoAmarelo.BackColor = System.Drawing.Color.LightCyan;
            this.painelVermelhoAmarelo.Controls.Add(this.panel5);
            this.painelVermelhoAmarelo.Controls.Add(this.panel3);
            this.painelVermelhoAmarelo.Controls.Add(this.panel1);
            this.painelVermelhoAmarelo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.painelVermelhoAmarelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelVermelhoAmarelo.Location = new System.Drawing.Point(245, 0);
            this.painelVermelhoAmarelo.Name = "painelVermelhoAmarelo";
            this.painelVermelhoAmarelo.Size = new System.Drawing.Size(957, 618);
            this.painelVermelhoAmarelo.TabIndex = 1;
            // 
            // painelLogo
            // 
            this.painelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.painelLogo.BackColor = System.Drawing.Color.PowderBlue;
            this.painelLogo.Controls.Add(this.Nome);
            this.painelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelLogo.Location = new System.Drawing.Point(0, 0);
            this.painelLogo.Name = "painelLogo";
            this.painelLogo.Size = new System.Drawing.Size(245, 59);
            this.painelLogo.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Navy;
            this.Nome.Location = new System.Drawing.Point(12, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(217, 43);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Gerenciador de Estoque";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // botaoHome
            // 
            this.botaoHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoHome.FlatAppearance.BorderSize = 0;
            this.botaoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoHome.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoHome.Location = new System.Drawing.Point(0, 59);
            this.botaoHome.Name = "botaoHome";
            this.botaoHome.Size = new System.Drawing.Size(245, 93);
            this.botaoHome.TabIndex = 1;
            this.botaoHome.Text = "Página Inicial";
            this.botaoHome.UseVisualStyleBackColor = true;
            this.botaoHome.Click += new System.EventHandler(this.botaoListaProdutos_Click);
            // 
            // botaoListaProdutos
            // 
            this.botaoListaProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoListaProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoListaProdutos.FlatAppearance.BorderSize = 0;
            this.botaoListaProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoListaProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoListaProdutos.Location = new System.Drawing.Point(0, 152);
            this.botaoListaProdutos.Name = "botaoListaProdutos";
            this.botaoListaProdutos.Size = new System.Drawing.Size(245, 93);
            this.botaoListaProdutos.TabIndex = 2;
            this.botaoListaProdutos.Text = "Lista de Produtos";
            this.botaoListaProdutos.UseVisualStyleBackColor = true;
            // 
            // botaoVenda
            // 
            this.botaoVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoVenda.FlatAppearance.BorderSize = 0;
            this.botaoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVenda.Location = new System.Drawing.Point(0, 245);
            this.botaoVenda.Name = "botaoVenda";
            this.botaoVenda.Size = new System.Drawing.Size(245, 93);
            this.botaoVenda.TabIndex = 3;
            this.botaoVenda.Text = "Cadastrar Venda";
            this.botaoVenda.UseVisualStyleBackColor = true;
            // 
            // botaoCompra
            // 
            this.botaoCompra.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.botaoCompra.FlatAppearance.BorderSize = 0;
            this.botaoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCompra.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCompra.Location = new System.Drawing.Point(0, 338);
            this.botaoCompra.Name = "botaoCompra";
            this.botaoCompra.Size = new System.Drawing.Size(245, 93);
            this.botaoCompra.TabIndex = 4;
            this.botaoCompra.Text = "Cadastrar Compra";
            this.botaoCompra.UseVisualStyleBackColor = true;
            this.botaoCompra.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 93);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fornecedores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 94);
            this.button2.TabIndex = 6;
            this.button2.Text = "Planilha de Contas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 537);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(36, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 537);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 24);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itens Abaixo do Limite";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(509, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 258);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 26);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Itens Proximos do Limite";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(410, 258);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Location = new System.Drawing.Point(509, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 258);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 26);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(136, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Itens Esgotados";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(410, 258);
            this.dataGridView3.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 618);
            this.Controls.Add(this.painelVermelhoAmarelo);
            this.Controls.Add(this.painelBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "Gerenciador de Estoque";
            this.painelBotoes.ResumeLayout(false);
            this.painelVermelhoAmarelo.ResumeLayout(false);
            this.painelLogo.ResumeLayout(false);
            this.painelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelBotoes;
        private System.Windows.Forms.Panel painelVermelhoAmarelo;
        private System.Windows.Forms.Panel painelLogo;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button botaoHome;
        private System.Windows.Forms.Button botaoCompra;
        private System.Windows.Forms.Button botaoVenda;
        private System.Windows.Forms.Button botaoListaProdutos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

