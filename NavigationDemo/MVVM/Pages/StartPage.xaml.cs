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
        Navigation.PushModalAsync(new Page2(txtName.Text));
        //NavUtilities.DeletePage(Navigation, "StartPage");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FinalPage());
    }
}


