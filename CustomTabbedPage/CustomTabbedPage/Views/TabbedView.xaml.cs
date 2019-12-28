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
    public partial class TabbedView : CustomTabbedPage.Controls.CustomTabbedPage
    {
        public TabbedView()
        {
            InitializeComponent();
        }
    }
}