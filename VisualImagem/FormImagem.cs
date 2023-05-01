using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualImagem
{
    public partial class FormImagem : Form
    {
        public FormImagem()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                dglAbrir.ShowDialog();
                if(dglAbrir.FileName != "")
                {
                    picImagem.Load(dglAbrir.FileName);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message + "\nO arquivo solicitado não é um arquivo de imagem", "**** ERRO DE ARQUIVO ****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja encerrar o programa?", "****** FINALIZANDO O PROGRAMA ******", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
