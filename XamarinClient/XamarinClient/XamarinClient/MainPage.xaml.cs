using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinClient.Helpers;

namespace XamarinClient
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_OnAppearing(object sender, EventArgs e)
        {
            var service = new ServiceReference1.SimpleServiceClient(WcfBindings.GetBasicHttpBinding(), new EndpointAddress("http://192.168.56.1:9001/SimpleService"));
            service.SinkRequestCompleted += (o, args) => { service.GetSimpleResponseAsync("Http - GetSimpleResponse"); };
            service.SinkRequestCompleted += (o, args) =>
            {
                if (!args.Cancelled && null != args.Error)
                    TextLabel.Text = args.ToString();
                else
                    TextLabel.Text = "Error!";
            };

            service.SinkRequestAsync("Http - sinkrequest");
        }

        private void Service_SinkRequestCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
