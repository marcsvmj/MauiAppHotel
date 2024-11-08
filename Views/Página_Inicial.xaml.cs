namespace MauiAppHotel.Views;

public partial class Página_Inicial : ContentPage
{
	public Página_Inicial()
	{
        InitializeComponent();
	}

    private async void btEntrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}