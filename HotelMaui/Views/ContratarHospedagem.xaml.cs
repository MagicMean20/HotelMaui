using HotelMaui.Models;

namespace HotelMaui.Views;

public partial class ContratarHospedagem : ContentPage
{
	App PropriedadesApp;

	public ContratarHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pckQuarto.ItemsSource = PropriedadesApp.listaQuartos;

		dtcheckIn.MinimumDate = DateTime.Now;
		dtcheckOut.MinimumDate = dtcheckIn.Date.AddDays(1);
		dtcheckOut.MaximumDate = dtcheckIn.Date.AddMonths(6);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

			Hospedagem h = new Hospedagem
			{
				QuartoSelecionado = (Quarto)pckQuarto.SelectedItem,
				qtdAdultos = Convert.ToInt32(stpAdultos.Value),
				qtdCriancas = Convert.ToInt32(stpCrianca.Value),
				dtcheckIn = dtcheckIn.Date,
				dtcheckOut = dtcheckOut.Date,
			};



			await Navigation.PushAsync(new HospedagemContratada()
			{
				BindingContext = h
			});

		} catch(Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtcheckIn_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime dataSelecionada = elemento.Date;

		dtcheckOut.MinimumDate = dataSelecionada.AddDays(1);
		dtcheckOut.MaximumDate = dataSelecionada.AddMonths(6);
    }
}