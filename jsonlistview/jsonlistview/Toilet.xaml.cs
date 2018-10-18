using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jsonlistview
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Toilet : ContentPage
	{
		public Toilet (Feature toilet)
		{
			InitializeComponent ();
            var lat = toilet.geometry.coordinates[1];
            var lgt = toilet.geometry.coordinates[0];
            string target = $"{lat},{lgt}";
            Title = toilet.properties.Navn;
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            var label = new Label { Text = toilet.properties.Adresse, FontSize = 20 };
            var label2 = new Label { Text = toilet.properties.Pris, FontSize = 20 };
            var mapButton = new Button { Text = "Show me the place", Command = SendToMapParam, CommandParameter = target };
            layout.Children.Add(label);
            layout.Children.Add(label2);
            layout.Children.Add(mapButton);
            this.Content = layout;
        }

        public ICommand SendToMapParam
        {
            get
            {
                return new Command<string>((x) => SendToMap(x));
            }
        }

        public void SendToMap(string x)
        {
              string str = $"http://www.google.com/maps/place/{x}";
              Device.OpenUri(new Uri(str));
        }
	}
}