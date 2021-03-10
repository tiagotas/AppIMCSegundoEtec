using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Globalization;

namespace AppIMCSegundoEtec
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

                double altura = Convert.ToDouble(txt_altura.Text);
                double peso = Convert.ToDouble(txt_peso.Text);

                double imc = peso / (altura * altura);

                string classificacao = "";

                // imc = 19.15

                // FALSO
                if(imc < 17)
                {
                    classificacao = "Muito abaixo do peso";

                    // imc = 19.15    E
                    //       VERDADEIRO  AND   FALSO
                } else if(imc >= 17 && imc < 18.49)
                {
                    classificacao = "Abaixo do peso";

                } else if(imc >= 18.5 && imc < 24.99)
                {
                    classificacao = "Peso Normal";

                } else if (imc >= 25 && imc < 29.99)
                {
                    classificacao = "Acima do Peso";

                } else if (imc >= 30 && imc < 34.99)
                {
                    classificacao = "Obesidade I";

                } else if (imc >= 35 && imc < 39.99)
                {
                    classificacao = "Obesidade II";

                } else
                {
                    classificacao = "Obesidade III (mórbida)";
                }

                lbl_resultado.Text = "Seu IMC é " + imc.ToString("0.00", nfi) + " " + classificacao;

            } catch(Exception ex)
            {
                lbl_resultado.Text = "Deu erro: " + ex.Message;
            }
        }
    }
}
