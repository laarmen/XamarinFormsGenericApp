using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsGenericApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void UseDependency(object sender, EventArgs args)
        {
            var dep = DependencyService.Get<IDependency>();
            // Aaaaaaaand crash.
            dep.DoStuff();
        }
    }
}
