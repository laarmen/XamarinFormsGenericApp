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
        public AbsoluteLayout Green { get; } = new AbsoluteLayout() { BackgroundColor = Color.Green };
        public AbsoluteLayout Red { get; } = new AbsoluteLayout() { BackgroundColor = Color.Red };
        public AbsoluteLayout AbsoluteGreen { get; } = new AbsoluteLayout() { BackgroundColor = Color.Green };
        public AbsoluteLayout AbsoluteRed { get; } = new AbsoluteLayout() { BackgroundColor = Color.Red };
        public MainPage()
        {
            InitializeComponent();
            ColorContainer.Children.Add(Green,
                xConstraint: Constraint.RelativeToParent((parent) => 0.125*parent.Width),
                yConstraint: Constraint.RelativeToParent((parent) => 0.25*parent.Height),
                widthConstraint: Constraint.RelativeToParent((parent) => parent.Width/2.0),
                heightConstraint: Constraint.RelativeToParent((parent) => parent.Height/2.0));
            ColorContainer.Children.Add(Red,
                xConstraint: Constraint.RelativeToParent((parent) => 0.25*parent.Width),
                yConstraint: Constraint.RelativeToParent((parent) => 0.33*parent.Height),
                widthConstraint: Constraint.RelativeToParent((parent) => parent.Width/2.0),
                heightConstraint: Constraint.RelativeToParent((parent) => parent.Height/2.0));
            AbsoluteColorContainer.Children.Add(AbsoluteGreen, new Rectangle(25, 50, 100, 100));
            AbsoluteColorContainer.Children.Add(AbsoluteRed, new Rectangle(50, 66, 100, 100));
        }
        public void BlueGreenRedLayout(object sender, EventArgs args)
        {
            ColorContainer.RaiseChild(Blue);
            ColorContainer.LowerChild(Green);
            ColorContainer.LowerChild(Red);
            ColorContainer.ForceLayout();

            AbsoluteColorContainer.RaiseChild(AbsoluteBlue);
            AbsoluteColorContainer.LowerChild(AbsoluteGreen);
            AbsoluteColorContainer.LowerChild(AbsoluteRed);
            AbsoluteColorContainer.ForceLayout();
        }
        public void BlueRedGreenLayout(object sender, EventArgs args)
        {
            ColorContainer.RaiseChild(Blue);
            ColorContainer.LowerChild(Red);
            ColorContainer.LowerChild(Green);
            ColorContainer.ForceLayout();

            AbsoluteColorContainer.RaiseChild(AbsoluteBlue);
            AbsoluteColorContainer.LowerChild(AbsoluteRed);
            AbsoluteColorContainer.LowerChild(AbsoluteGreen);
            AbsoluteColorContainer.ForceLayout();
        }
    }
}
