namespace Layouts;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}

    private async void OnClickedButton(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new StackLayoutPage());
    }
}