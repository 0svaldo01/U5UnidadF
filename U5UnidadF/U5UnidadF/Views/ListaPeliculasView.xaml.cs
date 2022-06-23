using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U5UnidadF.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace U5UnidadF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPeliculasView : ContentPage
    {
        public ListaPeliculasView()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgregarPeliculaView());
        }
        private async void SwipeItem_Clicked(object sender, EventArgs e)
        {
            //Preguntar por eliminar
            var sw = (SwipeItem)sender; //unboxing
            if (await DisplayAlert("Por favor confirme", $"¿Está seguro de eliminar a {((Pelicula)sw.CommandParameter).Titulo} ?", "Si", "No") == true)
            {
                avm.EliminarCommand.Execute(sw.CommandParameter);
            }

        }
    }
}