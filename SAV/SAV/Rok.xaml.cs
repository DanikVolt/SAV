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
    public partial class Rok : ContentPage
    {
        public Rok()
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
            Label nimetus = new Label { Text = "Року", FontSize = 30 };
            Image img = new Image { Source = "rok.jpg" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Року - Аватар после Киоши и перед Аангом. В последовательности цикла Аватаров, Року - уроженец страны Огня и, в первую очередь, маг огня. Являясь Аангу в духовной форме, он помогает юному Аватару советами и, если потребуется, защитой. Року духовный наставник Аанга. У Року был зверь-хранитель - дракон по имени Фэнг, который имел для него такое же значение, как Аппа для Аанга.  ", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            Label kirjeldus = new Label { Text = "Годы жизни: 82 ДГ - 12 ДГ (70 лет) " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }


    }
}