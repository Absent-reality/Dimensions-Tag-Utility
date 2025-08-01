namespace DimensionsTagUtility;

public partial class WindowsTagPage : ContentPage
{
    public WindowsTagPage(TagPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}