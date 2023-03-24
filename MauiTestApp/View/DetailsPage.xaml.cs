namespace MauiTestApp.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(MonkeyDetailsVM model)
	{
		InitializeComponent();
		BindingContext = model;
	}


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}