namespace DimensionsTagUtility
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UserAppTheme = AppTheme.Dark;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            const int startWidth = 820;
            const int startHeight = 620;

            var window = new Window(new AppShell())
            {
               MinimumWidth = startWidth,
               Width = startWidth,
               MinimumHeight = startHeight,
               Height = startHeight
            };
            return window;
        }
    }
}