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
    public partial class Calculator : ContentPage
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void atrapardato(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            var num = b.Text;
            visu.Text = num;
        }

        private void atraparope(object sender, EventArgs e)
        {
            Button d = (Button)sender;
            var num = d.Text;
            visu.Text = num;
        }
    }
}