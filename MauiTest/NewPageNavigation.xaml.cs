namespace MauiTest;

public partial class NewPageNavigation : ContentPage
{
	public NewPageNavigation()
	{
		InitializeComponent();
	}

	private void OnNavigationClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}

}