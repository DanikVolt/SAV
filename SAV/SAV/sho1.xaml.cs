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
    public partial class sho1 : ContentPage
    {
        public sho1()
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
            Label nimetus = new Label { Text = "Зето", FontSize = 30 };
            Image img = new Image { Source = "sho1.jpg" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Зето был Аватаром до Янгчен. Он появлялся в нескольких сериях Легенды об Аанге, а его имя впервые было упомянуто в книге Тень Киоши. Живя в эпоху огромного кризиса, который грозил уничтожить Нацию Огня, Зето спас свою родную страну, став бюрократом, дипломатом и финансистом на службе у Хозяина Огня Йосора. В конце концов, получив звание Великого советника, Зето значительно укрепил правительство Народа Огня, восстановил экономический баланс и создал программы помощи бедным и нуждающимся.   ", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            Label kirjeldus = new Label { Text = "Годы жизни: Неизвестны  " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }


    }
}