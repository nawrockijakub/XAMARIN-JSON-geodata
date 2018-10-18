using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using static jsonlistview.ToiletCollection;

namespace jsonlistview
{

    public partial class MainPage : ContentPage
    {
        readonly IList<RootObject> toilets = new ObservableCollection<RootObject>();
        public MainPage()
        {
            InitializeComponent();
            ToiletCollection tc = new ToiletCollection();
            var toilets = tc.GetData();
            BindingContext = toilets.features;
        }


        public async void ItemTapped(object sender, ItemTappedEventArgs e) {
            Feature selected = (Feature)e.Item;
            //DependencyService.Get<FunFlactsViewModel>().CurrentFlag = selected;
            await Navigation.PushModalAsync(new NavigationPage(new Toilet(selected)));
        }
        public void ItemDelete(object sender, EventArgs e) { }
    }
    
}
