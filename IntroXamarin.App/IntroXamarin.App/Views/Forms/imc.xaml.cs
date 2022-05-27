using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imc : ContentPage
    {
        public Imc()
        {
            InitializeComponent();
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            bool required = false;
            if (string.IsNullOrEmpty(Peso.Text))
            {
                required = true;
                Peso.BackgroundColor = Color.Red;
                Peso.Opacity = 50;
            }
            if (required)
            {
                DisplayAlert("Error", "Por favor, ingrese sus datos", "Volver");
                return;
            }

            Indicator.IsRunning = true;

            var peso = Peso.Text;
            var altura = Altura.Text;
            var IMC = 0;
            //var Result = 0;
            //result =  (result / (peso * altura));



            var message = $"Tu peso es {peso} {altura}.";
            DisplayAlert("Resultado", message, "Cancel");

            if (IMC < 18.5)
            {
            
            }

            if ((IMC >= 18.5) && (IMC < 24.9))
            {
               
            }

            if ((IMC >= 25) && (IMC < 29.9))
            {
              
            }
            if ((IMC >= 30) && (IMC < 40))
            {
              
            }
            if (IMC >= 40)
            {
             
            }
            Indicator.IsRunning = false;
        }


			
        

        }
    }

