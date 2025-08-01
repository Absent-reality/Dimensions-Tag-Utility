namespace DimensionsTagUtility;

public partial class TagUtilityPage : ContentPage
{
    public TagUtilityPage(TagPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}