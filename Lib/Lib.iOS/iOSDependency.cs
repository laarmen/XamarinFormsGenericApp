using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(Lib.iOS.iOSDependency))]
namespace Lib.iOS
{
    [Foundation.Preserve(AllMembers = true)]
    class iOSDependency: IDependency
    {
        public void DoStuff()
        {
            Console.WriteLine("Doing stuff on iOS.");
        }
    }
}