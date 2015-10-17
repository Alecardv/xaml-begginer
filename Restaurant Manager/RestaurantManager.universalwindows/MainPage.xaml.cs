using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RestaurantManager.universalwindows
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage() {
            this.InitializeComponent();
        }

        private void Button_Click_Order(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ExpeditePage));
        }

        private void Button_Click_Submit(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OrderPage));
        }
    }
}
