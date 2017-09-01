using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestRecorderApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        List<Talk> Talks = new List<Talk>();
        public ProfilePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Talks = new List<Talk>()
            {
                new Talk()
                {
                    Title = "Introducing Xamarin Test Recorder",
                    Event = "Mobile .NET Developers - September Session",
                    Time = "11:30AM - 12:30PM"
                },
                new Talk()
                {
                    Title = "Xamarin + Azure Easy Tables",
                    Event = "Azure Global Meetup",
                    Time = "4:00PM - 5:00PM"
                },
                new Talk()
                {
                    Title = "Introducing Xamarin.UITest",
                    Event = "Xamarin: Debugging and Testing",
                    Time = "3:00PM - 4:00PM"
                },
                new Talk()
                {
                    Title = "Bot Framework + Xamarin.Forms",
                    Event = "Xamarin Fiesta",
                    Time = "1:00PM - 2:00PM"
                },new Talk()
                {
                    Title = "Visual Studio Mobile Center",
                    Event = "Mobile Devops",
                    Time = "2:00PM - 3:00PM"
                }
            };

            listView.ItemsSource = Talks;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = e.NewTextValue.ToString();
            var filtered = Talks.Where(t => t.Title.ToLower().Contains(search.ToLower())).ToList();

            listView.ItemsSource = filtered;
        }
    }

    public class Talk
    {
        public string Title { get; set; }
        public string Event { get; set; }
        public string Time { get; set; }
    }
}
