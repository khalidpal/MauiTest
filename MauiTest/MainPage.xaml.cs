using Microsoft.Maui.Essentials;

namespace MauiTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}

	private void OnNavigationClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NewPageNavigation());
	}

	private void OnNewClicked(object sender, EventArgs e)
	{
		var secondWindow = new Window
		{
			Page = new NewPageNew()
		};
		Application.Current.OpenWindow(secondWindow);
	}

}

