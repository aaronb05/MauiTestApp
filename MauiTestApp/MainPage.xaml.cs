namespace MauiTestApp;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeyVM model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}

