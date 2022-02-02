namespace MauiTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new MainPage();
	}


	protected override Window CreateWindow(IActivationState activationState) =>
		new Window(new NavigationPage(new MainPage())) { Title = "MyApp" };

}
