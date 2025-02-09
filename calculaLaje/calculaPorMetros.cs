using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculaLaje;

namespace calculaLaje
{
    public partial class calculaPorMetros : Form
    {
        public calculaPorMetros()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //Atrelando o valor dos campos e variaveis.
            double metragem = double.Parse(metros.Text);
            double vigas = double.Parse(viga.Text);

            //Calculo do valor quebrado para separar os burros.
            double ladoInteiro = Math.Truncate(vigas);
            double quebrado = Math.Round((vigas - ladoInteiro), 1);

            //Definição da variavel zerada para usar abaixo.
            double vigaCerta;

            //Erro vigas igual a zero
            if (viga.Text == "0")
            {
                colorDialog1.Color = Color.Red;
                errorProvider1.SetError(viga, "Não pode ser o valor nulo ou zero");
                viga.Focus();
            }
            else
            {

                //Calculo para mudar viga de impar para par.
                if (quebrado == 0.1 || quebrado == 0.3 || quebrado == 0.5 || quebrado == 0.7 || quebrado == 0.9)
                {
                    vigaCerta = vigas + 0.1;
                }
                else
                {
                    vigaCerta = vigas;
                }

                double qtd = 1;
                double auxiliar = vigaCerta * qtd * 0.38;

                while (metragem > auxiliar)
                {
                    qtd++;
                    auxiliar = vigaCerta * qtd * 0.38;
                }
                qtd--;

                string mtQuadrado = (vigaCerta * qtd * 0.38).ToString();
                string lajota25 = Math.Round(vigaCerta * qtd * 0.38 * 13).ToString();
                string lajota30 = Math.Round(vigaCerta * qtd * 0.38 * 11.5).ToString();
                string isopor = Math.Round(vigaCerta * qtd * 0.38 * 2.02).ToString();

                resultados.AppendText("São:\n \n" + qtd.ToString() + " Vigas de " + vigaCerta.ToString() + " MTS \n" + mtQuadrado + " M² \n\nSeriam: \n" + lajota25 + " Lajotas de 25cm \n" + lajota30 + " Lajotas de 30cm \n" + isopor + " Placas de Isopor \n \n");
                qtd++;

                string mtQuadrado2 = (vigaCerta * qtd * 0.38).ToString();
                string lajota252 = Math.Round(vigaCerta * qtd * 0.38 * 13).ToString();
                string lajota302 = Math.Round(vigaCerta * qtd * 0.38 * 11.5).ToString();
                string isopor2 = Math.Round(vigaCerta * qtd * 0.38 * 2.02).ToString();

                resultados.AppendText("Ou:\n \n" + qtd.ToString() + " Vigas de " + vigaCerta.ToString() + " MTS \n" + mtQuadrado2 + " M² \n\n Seriam: \n" + lajota252 + " Lajotas de 25cm \n" + lajota302 + " Lajotas de 30cm \n" + isopor2 + " Placas de Isopor \n \n");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
