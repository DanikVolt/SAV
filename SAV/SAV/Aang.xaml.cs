using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aang : ContentPage
    {
        public Aang()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(3,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(2,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            Label nimetus = new Label { Text = "Аанг", FontSize = 30 };
            Image img = new Image { Source = "ang.webp" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", " Аанг - единственный оставшийся в живых представитель нации Воздушных кочевников, которые были уничтожены Народом Огня в 0 году ПГ. Он является Аватаром - человеком, способным использовать все четыре вида магии: воздуха, воды, земли и огня. Именно с целью его убийства Народ Огня напал на мирных монахов. Аанг сбежал от своих наставников незадолго до этих событий, но оказался замороженным в айсберге на следующие сто лет. Всё это время в мире шла война. После пробуждения Аанг должен исполнить свою миссию: освоить все виды магии и вернуть мир. ", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            Label kirjeldus = new Label { Text = "12 ДГ - 154 ПГ (166 лет) " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }


    }
}