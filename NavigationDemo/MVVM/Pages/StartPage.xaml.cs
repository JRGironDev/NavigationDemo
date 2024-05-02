using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class StartPage : ContentPage
{

	public StartPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FinalPage());
    }
}


