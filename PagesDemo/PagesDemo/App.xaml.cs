using PagesDemo.Resources;

namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var navPage = new NavigationPage(new MainPage())
        {
            Background = Colors.Chocolate,
            BarTextColor = Colors.White
        };

        MainPage = new FlyoutPageDemo();
	}
}
