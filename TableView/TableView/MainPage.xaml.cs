using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TableView
{
    public partial class MainPage : ContentPage
    {
        void Initlizing()
        {
            List<ImageObject> lists = new List<ImageObject>();
            lists.Add(new ImageObject{ image="anh1.jpg", title="Liverpool"});
            lists.Add(new ImageObject { image = "anh1.jpg", title = "Liverpool" });
            lists.Add(new ImageObject { image = "anh2.jpg", title = "Manchester" });
            lists.Add(new ImageObject { image = "hn.jpg", title = "Hà nội" });
            lists.Add(new ImageObject { image = "hcm.jpg", title = "Hồ chí minh" });
            listImage.ItemsSource = lists;
        }
        public MainPage()
        {
            InitializeComponent();
            Initlizing();
        }
    }
}
