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
    public partial class kio : ContentPage
    {
        public kio()
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
            Label nimetus = new Label { Text = "Киоши", FontSize = 30 };
            Image img = new Image { Source = "kio.jpg" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", " Киоши - один из предшествовавших Аангу и Корре Аватаров. Она прожила целых 230 лет и является самым долгоживущим из Аватаров. Киоши была очень высокой и обладала ногой огромного для женщины размера. Родилась в семье двух преступников: Джессы, монахини-отступницы из воздушных кочевников, и Харка, вора из обедневшей семьи актёров из царства Земли. Она унаследовала свой фирменный наряд от родителей, переняв золотой головной убор и металические боевые веера от матери, а также макияж от отца. Она умерла за 180 лет до событий сериала. ", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            Label kirjeldus = new Label { Text = "Годы жизни: 312 ДГ - 82 ДГ (230 лет)  " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }


    }
}