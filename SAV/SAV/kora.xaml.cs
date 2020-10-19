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
    public partial class kora : ContentPage
    {
        public kora()
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
            Label nimetus = new Label { Text = "Корра", FontSize = 30 };
            Image img = new Image { Source = "kor.jpg" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Корра - текущее воплощение Аватара и следующее воплощение после Аанга. Она родилась и выросла в Южном Племени Воды, где она освоила магию воды, магию земли и магию огня. Позже она переехала в Город Республика для того, чтобы обучиться магии воздуха под руководством Тензина, а также преодолеть свою неприязнь к духовным аспектам этой магии. С помощью духа Аанга Корра получила способность к магии энергии и после встречи со своими прошлыми жизнями могла войти в состояние Аватара по своему желанию, став Абсолютным Аватаром.  ", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            Label kirjeldus = new Label { Text = "Годы жизни: 154 ПГ - по настоящее время " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }


    }
}