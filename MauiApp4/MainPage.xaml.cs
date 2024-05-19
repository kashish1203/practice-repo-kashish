namespace MauiApp4;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void ControlBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ControlDemo());
    }
}
