using AccessibilityDemo.ViewModels;

namespace AccessibilityDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        BindingContext = new MainViewModel();

        InitializeComponent();
    }

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Task.Delay(1000);
        SemanticScreenReader.Announce("Menu Tapped");
    }

    async void TapGestureRecognizer_Tapped_1(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Task.Delay(1000);
        SemanticScreenReader.Announce("Options Tapped");
    }
}
