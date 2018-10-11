using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;

namespace jsonlistview
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ToiletCollection tc = new ToiletCollection();
            tc.GetData();
            Label label = new Label { Text = "testing", BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black };
            Content = label;
           // System.Diagnostics.Debug.WriteLine(list);
        }
    }
}
