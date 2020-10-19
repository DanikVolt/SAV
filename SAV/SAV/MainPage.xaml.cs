using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SAV
{
    public partial class MainPage : ContentPage
    {
        Button btn1;
        Image im;
        public MainPage()
        {
            AbsoluteLayout abs = new AbsoluteLayout();

            im = new Image { Source = "js.jpg", };
			abs.Children.Add(im);
			btn1 = new Button { Text = "Перейти к списку аватаров", BackgroundColor = Color.LightYellow, };
			btn1.Clicked += Btn1_Clicked;
			AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.5, 0.5, 250, 50));
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(btn1);
            Content = abs;
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }
    }
	
    
}
