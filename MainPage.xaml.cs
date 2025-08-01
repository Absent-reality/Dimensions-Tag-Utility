

namespace DimensionsTagUtility
{
    public partial class MainPage : ContentPage
    {
        public MainPage(TagPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            this.Loaded += Page_Loaded;
        }

        private async void Page_Loaded(object? sender, EventArgs e)
        {
            Img_grd.Source = "tagutil_logo.png";
            Img_grd.Scale = 1;
            await Stuff.FadeTo(1, 1000);
            await Img_grd.FadeTo(1, 1000);
            await Task.Delay(1000);
            await Stuff.FadeTo(0, 1000);
            await Img_grd.FadeTo(0, 250);
            Img_grd.Source = "gear_logo.png";
            Img_grd.Scale = .50;
            await Stuff.FadeTo(1, 1000);
            await Img_grd.FadeTo(1, 1000);
            await lbl_txt.FadeTo(1, 1000);
            //          lbl_txt.IsVisible = true;
            await Task.Delay(1000);
            await Stuff.FadeTo(0, 1000);
            await lbl_txt.FadeTo(0, 250);
            await Img_grd.FadeTo(0, 250);
            await Task.Delay(3000);
//#if ANDROID
            await Shell.Current.GoToAsync($"///TagUtilityPage");
//#endif
//#if WINDOWS
//            await Shell.Current.GoToAsync($"///WindowsTagPage");
//#endif 
        }

    }
}
