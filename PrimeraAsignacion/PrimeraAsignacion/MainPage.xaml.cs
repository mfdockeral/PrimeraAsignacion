using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace PrimeraAsignacion
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		//Evento del botón mostrar.
		private void btnMostrar_Clicked(object sender, EventArgs e)
		{
			var texto = TxtNom.Text;
			this.DisplayAlert("Bienvenido a nuestra primera asignación", texto, "Ok");
			TxtNom.Text = "";
		}
	}
}
