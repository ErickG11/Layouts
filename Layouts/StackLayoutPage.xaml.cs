namespace Layouts;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}
    private async void OnClickedButtonFlex(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FlexLayoutPage());
    }
}