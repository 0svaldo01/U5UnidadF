using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using U5UnidadF.Views; 

namespace U5UnidadF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListaPeliculasView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
