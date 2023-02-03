namespace FrontMaui.Pages;

public partial class Inicio_Page : ContentPage
{
	public Inicio_Page()
	{
		InitializeComponent();
	}

    private async void onBtnUnirse(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SeleccionSala_Page());
    }

    private async void onBtnCrear(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AnteSala_Page());
    }
}