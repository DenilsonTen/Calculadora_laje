using System;
using System.Windows.Forms;

namespace CalculaLaje
{
    public partial class calcularPorVigas : Form
    {
        public calcularPorVigas()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Definindo os parametros para calculo.
            int vigas = int.Parse(qtdVigas.Text);
            double metragem = double.Parse(metragemVigas.Text);

            //Calculo do valor quebrado para separar os burros.
            double ladoInteiro = Math.Truncate(metragem);
            double quebrado = Math.Round((metragem - ladoInteiro), 1);

            //Definição da variavel zerada para usar abaixo.
            double vigaCerta;

            //Calculo para mudar viga de impar para par.
            if (quebrado == 0.1 || quebrado == 0.3 || quebrado == 0.5 || quebrado == 0.7 || quebrado == 0.9)
            {
                vigaCerta = metragem + 0.1;
            }
            else
            {
                vigaCerta = metragem;
            }

            //Cria a string de lajota
            string tipo = lajotaIsopor.SelectedItem.ToString();

            //Calculo da metragem das vigas
            if (tipo == "Lajota 25")
            {
                double cal25 = vigas * vigaCerta * 0.38;
                int qtd = (int)Math.Round(cal25 * 13);

                resultados.AppendText(cal25 + " M²" + "\n" + qtd + " Lajotas 25cm" + "\n \n");
            }
            else if (tipo == "Lajota 30")
            {
                double cal25 = vigas * vigaCerta * 0.42;
                int qtd = (int)Math.Round(cal25 * 11.5);

                resultados.AppendText(cal25 + " M²" + "\n" + qtd + " Lajotas 30cm" + "\n \n");
            }
            else
            {
                double cal25 = vigas * vigaCerta * 0.42;
                int qtd = (int)Math.Round(cal25 * 2.02);

                resultados.AppendText(cal25 + " M²" + "\n" + qtd + " Placas de Isopor" + "\n \n");
            }
        }
     }
}
