using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace jsonlistview
{
    public class ToiletCollection
    {
        public class Geometry
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
        }

        public class Properties
        {
            public string Navn { get; set; }
            public string Adresse { get; set; }
            public string Beskrivelse { get; set; }
            public string Pris { get; set; }
            public string Type { get; set; }
            public string Inaktiv { get; set; }
        }

        public class Feature
        {
            public string type { get; set; }
            public string id { get; set; }
            public Geometry geometry { get; set; }
            public string geometry_name { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties2
        {
            public string code { get; set; }
        }

        public class Crs
        {
            public string type { get; set; }
            public Properties2 properties { get; set; }
        }

        public class RootObject
        {
            public string type { get; set; }
            public List<Feature> features { get; set; }
            public Crs crs { get; set; }
            public List<double> bbox { get; set; }
        }

        public ToiletCollection()
        {
        }

        public void GetData()
        {
            //WebClient is disposable
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://portal.opendata.dk/dataset/99e2a056-3350-4f6d-ae5f-77766a2c7011/resource/50c64627-2bde-4406-a958-8f45237b1eb6/download/hctoiletterodense.json");
                //using online version because xamarin cant find the local file
                var ts = JsonConvert.DeserializeObject<RootObject>(json);
                //deserialize root object which contains all other properties
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
                System.Diagnostics.Debug.WriteLine(ts.features[0].geometry_name);
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
            }
        }
    }
}
