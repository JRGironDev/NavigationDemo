namespace NavigationDemo.MVVM.Pages;

public partial class FinalPage : ContentPage
{

	public FinalPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}
