using PrismProject.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace PrismProject
{
  public partial class App : PrismApplication
  {
    public App()
    {
      InitializeComponent();


    }

    protected override void OnInitialized()
    {
      NavigationService.NavigateAsync("Navigation/MainPage").ContinueWith(t =>
      {
        if (t.Exception != null)
          throw t.Exception;
      });
    }

    protected override void RegisterTypes()
    {
      Container.RegisterTypeForNavigation<NavigationPage>("Navigation");
      Container.RegisterTypeForNavigation<MainPage>("MainPage");
    }


    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
