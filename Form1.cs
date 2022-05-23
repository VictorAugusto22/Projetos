using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cálculo_de_preço
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Calcular_Click(object sender, EventArgs e)
        {
            //VALIDAR PREENCHIMENTO DAS CAIXAS DE TEXTO
            if (Tb_preco.Text != "" && Tb_desconto.Text != "")
            {   // SE FOR VERDADEIRO
                //DECLARAR E ATRIBUIR AS VARIÁVEIS
                decimal preco = Convert.ToDecimal(Tb_preco.Text);
                decimal desconto = Convert.ToDecimal(Tb_desconto.Text);
                decimal valor_de_desconto ;
                decimal valor;
                //CÁLCULO DA MÉDIA
                valor_de_desconto = (preco * desconto) / 100;
                valor = (preco - valor_de_desconto);

                //EXIBIR O CÁLCULO DA PORCENTAGEM
                
                Lb_Valor.Text = Convert.ToString(valor);
                
            }
            else //SE FOR FALSO - validação preenchimento das caixas de texto
            {
                MessageBox.Show("Favor preencher todas as notas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
