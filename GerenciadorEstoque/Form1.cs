using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void botaoListaProdutos_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoPlanilhaVermelho_Click(object sender, EventArgs e)
        {
            botaoPlanilhaVermelho.BackColor = Color.FromArgb(158, 176, 199);
            botaoPlanilhaAmarelo.BackColor = Color.LightSteelBlue;
            botaoPlanilhaPreto.BackColor = Color.LightSteelBlue;
        }

        private void botaoVenda_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void painelVermelhoAmarelo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painelBotões_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoPlanilhaAmarelo_Click(object sender, EventArgs e)
        {
            botaoPlanilhaVermelho.BackColor = Color.LightSteelBlue;
            botaoPlanilhaAmarelo.BackColor = Color.FromArgb(158, 176, 199);
            botaoPlanilhaPreto.BackColor = Color.LightSteelBlue;
        }

        private void botaoPlanilhaPreto_Click(object sender, EventArgs e)
        {
            botaoPlanilhaVermelho.BackColor = Color.LightSteelBlue;
            botaoPlanilhaAmarelo.BackColor = Color.LightSteelBlue;
            botaoPlanilhaPreto.BackColor = Color.FromArgb(158, 176, 199);
        }

        private void botaoListaProdutos_Click_1(object sender, EventArgs e)
        {

        }

        private void botaoPaginaInicial_Click(object sender, EventArgs e)
        {

        }

        private void botaoVenda_Click_1(object sender, EventArgs e)
        {

        }

        private void botaoCompras_Click(object sender, EventArgs e)
        {

        }

        private void botaoFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void textoPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoNomeProduto_Click(object sender, EventArgs e)
        {

        }

        private void botaoPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            /*//----------Botão Preto ----------------------------
            GraphicsPath raioElipseBotaoPreto = new GraphicsPath();
            raioElipseBotaoPreto.StartFigure();
            raioElipseBotaoPreto.AddLine(0, 0, botaoPlanilhaPreto.Width, 0);
            raioElipseBotaoPreto.AddLine(botaoPlanilhaPreto.Width, 0, botaoPlanilhaPreto.Width, botaoPlanilhaPreto.Height - 10);
            raioElipseBotaoPreto.AddArc(new Rectangle(botaoPlanilhaPreto.Width - 10, botaoPlanilhaPreto.Height - 10, 10, 10), 0, 90);
            raioElipseBotaoPreto.AddLine(botaoPlanilhaPreto.Width - 10, botaoPlanilhaPreto.Height, 20, botaoPlanilhaPreto.Height);
            raioElipseBotaoPreto.AddArc(new Rectangle(0, botaoPlanilhaPreto.Height - 10, 10, 10), 90, 90);
            raioElipseBotaoPreto.CloseAllFigures();
            botaoPlanilhaPreto.Region = new Region(raioElipseBotaoPreto);
            //----------Botão vermelho ----------------------------
            GraphicsPath raioElipseBotaoVermelho = new GraphicsPath();
            raioElipseBotaoVermelho.StartFigure();
            raioElipseBotaoVermelho.AddLine(0, 0, botaoPlanilhaPreto.Width, 0);
            raioElipseBotaoVermelho.AddLine(botaoPlanilhaVermelho.Width, 0, botaoPlanilhaVermelho.Width, botaoPlanilhaVermelho.Height - 10);
            raioElipseBotaoVermelho.AddArc(new Rectangle(botaoPlanilhaVermelho.Width - 10, botaoPlanilhaVermelho.Height - 10, 10, 10), 0, 90);
            raioElipseBotaoVermelho.AddLine(botaoPlanilhaVermelho.Width - 10, botaoPlanilhaVermelho.Height, 20, botaoPlanilhaVermelho.Height);
            raioElipseBotaoVermelho.AddArc(new Rectangle(0, botaoPlanilhaVermelho.Height - 10, 10, 10), 90, 90);
            raioElipseBotaoVermelho.CloseAllFigures();
            botaoPlanilhaVermelho.Region = new Region(raioElipseBotaoVermelho);
            //--------Botão Amarelo -----------------------------
            GraphicsPath raioElipseBotaoAmarelo = new GraphicsPath();
            raioElipseBotaoAmarelo.StartFigure();
            raioElipseBotaoAmarelo.AddLine(0, 0, botaoPlanilhaAmarelo.Width, 0);
            raioElipseBotaoAmarelo.AddLine(botaoPlanilhaAmarelo.Width, 0, botaoPlanilhaAmarelo.Width, botaoPlanilhaAmarelo.Height - 10);
            raioElipseBotaoAmarelo.AddArc(new Rectangle(botaoPlanilhaAmarelo.Width - 20, botaoPlanilhaAmarelo.Height - 20, 20, 20), 0, 90);
            raioElipseBotaoAmarelo.AddLine(botaoPlanilhaAmarelo.Width - 10, botaoPlanilhaAmarelo.Height, 20, botaoPlanilhaAmarelo.Height);
            raioElipseBotaoAmarelo.AddArc(new Rectangle(0, botaoPlanilhaAmarelo.Height - 10, 10, 10), 90, 90);
            raioElipseBotaoAmarelo.CloseAllFigures();
            botaoPlanilhaAmarelo.Region = new Region(raioElipseBotaoAmarelo);
            //-------Botao Pesquisa --------------------------------*/
            GraphicsPath raioElipse = new GraphicsPath();
            raioElipse.StartFigure();
            raioElipse.AddArc(new Rectangle(0, 0, 10, 10), 180, 90);
            raioElipse.AddLine(10, 0, botaoPesquisa.Width - 20, 0);
            raioElipse.AddArc(new Rectangle(botaoPesquisa.Width - 10, 0, 10, 10), -90, 90);
            raioElipse.AddLine(botaoPesquisa.Width, 20, botaoPesquisa.Width, botaoPesquisa.Height - 10);
            raioElipse.AddArc(new Rectangle(botaoPesquisa.Width - 10, botaoPesquisa.Height - 10, 10, 10), 0, 90);
            raioElipse.AddLine(botaoPesquisa.Width - 10, botaoPesquisa.Height, 20, botaoPesquisa.Height);
            raioElipse.AddArc(new Rectangle(0, botaoPesquisa.Height - 10, 10, 10), 90, 90);
            raioElipse.CloseAllFigures();
            botaoPesquisa.Region = new Region(raioElipse);
            botaoPlanilhaVermelho.BackColor = Color.FromArgb(158, 176, 199);
            painelDataGrid.BackColor = Color.FromArgb(158, 176, 199);
        }

        private void painelDataGrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
