namespace Layouts;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();

	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}