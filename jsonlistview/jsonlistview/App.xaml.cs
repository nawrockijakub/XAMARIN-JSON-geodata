using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace jsonlistview
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

           
            //  using (WebClient wc = new WebClient())
            //  {var json = wc.DownloadString("https://portal.opendata.dk/dataset/99e2a056-3350-4f6d-ae5f-77766a2c7011/resource/50c64627-2bde-4406-a958-8f45237b1eb6/download/hctoiletterodense.json");
            //      ToiletCollection toiletList = JsonConvert.DeserializeObject<ToiletCollection>(json);}
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
