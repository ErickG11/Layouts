namespace Layouts;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

	private async void boton1_clicked (object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayoutPage());
}

}