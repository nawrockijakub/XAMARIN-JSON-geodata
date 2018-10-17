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
        //readonly ToiletManager manager = new ToiletManager();
        public MainPage()
        {
            InitializeComponent();

            ToiletCollection tc = new ToiletCollection();
            var toilets = tc.GetData();
            BindingContext = toilets.features;

            
            // foreach(var item in toilets)
            // {
            ////     System.Diagnostics.Debug.WriteLine(item.features[0].properties.Navn);
            // }
            System.Diagnostics.Debug.WriteLine(toilets.features[0].properties.Navn);
            System.Diagnostics.Debug.WriteLine(toilets.features[1].properties.Navn);
            System.Diagnostics.Debug.WriteLine(toilets.features[2].properties.Navn);
        }
        public void ItemTapped(object sender, EventArgs e) { }
        public void ItemDelete(object sender, EventArgs e) { }
    }
    
}
