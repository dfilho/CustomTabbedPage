using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabbedPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1View : ContentPage
    {
        public Page1View()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //NavigationPage navigation = new NavigationPage();
            //navigation.Navigation.PushAsync(new Pagina1NavegacaoView());

            Navigation.PushAsync(new Pagina1NavegacaoView());
        }
    }
}