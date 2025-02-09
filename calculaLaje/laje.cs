using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculaLaje;

namespace CalculaLaje
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //Cria as variaveis comprimento e largura com base no valor colocado em lado1 e lado2
            double comprimento = double.Parse(lado1.Text);
            double largura = double.Parse(lado2.Text);

            //Cria a variavel de verificação de lado com base em ladoViga.
            double ladoVigas = double.Parse(ladoViga.Text);

            //Cria a variavel das lajotas e isopor.
            string lajotaIsopor = qual.SelectedItem as string;

            //Criação da variavel vigacerta para uso furuto
            double vigaCerta = 0.00;

            //Retorna o valor após o . do número
            double ladoInteiro = Math.Truncate(ladoVigas);
            double quebrado = Math.Round((ladoVigas - ladoInteiro), 1);

            //Verificar se o valor de lado vigas é impar e muda ele.
            if (quebrado == 0.1 || quebrado == 0.3 || quebrado == 0.5 || quebrado == 0.7 || quebrado == 0.9 ) 
            {
                vigaCerta += ladoVigas + 0.10;
            }
            else
            {
                vigaCerta = ladoVigas;
            }
            //Evita o erro de dado lado1 e lado2 diferente do ladoVigas.
            if (comprimento != ladoVigas && largura != ladoVigas)
            {
                MessageBox.Show("Confira os dados do campo 3");
                ladoViga.Focus();
            }
            //Calcula a laje se o valor 1 for igual ao 3;
            if (comprimento == ladoVigas && lajotaIsopor == "Lajota 25")
            {
                //Calculo da quantidade de vigas.
                int qtdVigas = (int)Math.Round(largura / 0.38);

                //Calculo da quantidade de Isopor.
                double qtdLajota25 = Math.Round(qtdVigas * vigaCerta * 0.38 * 13);

                //Calculo da metragem da laje
                double metragem = (vigaCerta * qtdVigas * 0.38);

                resultados.AppendText(qtdVigas + " Vigas de " + vigaCerta + "Mts" + "\n" + qtdLajota25 + " Lajotas de 25Cm" + "\n" + metragem + " M²" + "\n \n");
            } else if(comprimento == ladoVigas && lajotaIsopor == "Lajota 30")
            {
                //Calculo da quantidade de vigas.
                int qtdVigas = (int)Math.Round(largura / 0.42);

                //Calculo da quantidade de Isopor.
                double qtdLajota25 = Math.Round(qtdVigas * vigaCerta * 0.42 * 11.5);

                //Calculo da metragem da laje
                double metragem = (vigaCerta * qtdVigas * 0.42);

                //Impressão dos dados no resultado.
                resultados.AppendText(qtdVigas + " Vigas de " + vigaCerta + "Mts" + "\n" + qtdLajota25 + " Lajotas de 30Cm" + "\n" + metragem + " M²" + "\n \n");
            } else if (comprimento == ladoVigas && lajotaIsopor == "Isopor")
            {
                //Calculo da quantidade de vigas.
                int qtdVigas = (int)Math.Round(largura / 0.42);

                //Calculo da quantidade de Isopor.
                double qtdLajota25 = Math.Round(qtdVigas * vigaCerta * 0.42 * 2.02);

                //Calculo da metragem da laje
                double metragem = (vigaCerta * qtdVigas * 0.42);

                //Impressão dos dados no resultado.
                resultados.AppendText(qtdVigas + " Vigas de " + vigaCerta + "Mts" + "\n" + qtdLajota25 + " Placas de Isopor" + "\n" + metragem + " M²" + "\n \n");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calcularPorVigas calcularPorVigas = new calcularPorVigas();
            Hide();
            calcularPorVigas.ShowDialog();
            Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calculaPorMetros calc = new calculaPorMetros();
            Hide();
            calc.ShowDialog();
            Show();
        }
    }
}
