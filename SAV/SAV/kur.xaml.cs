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
    public partial class kur : ContentPage
    {
        public kur()
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
            Label nimetus = new Label { Text = "Курук", FontSize = 30 };
            Image img = new Image { Source = "kur.jpg" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Курук - один из предшествовавших Аангу аватаров из Племени Воды. Он умер за 400 лет до событий сериала, после чего его заменила Аватар Киоши.  ", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            Label kirjeldus = new Label { Text = "345 ДГ - 312 год ДГ (33 года)  " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }


    }
}