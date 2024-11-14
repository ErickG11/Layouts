namespace Layouts;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();

	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        // Navega a la página de AbsoluteLayout cuando se hace clic en una imagen
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}