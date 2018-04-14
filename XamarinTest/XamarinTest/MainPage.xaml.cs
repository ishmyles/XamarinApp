using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest
{
	public partial class MainPage : ContentPage
	{
        QuotesPage qp = new QuotesPage();

        public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            quoteLabel.Text = qp.GenerateQuote();
        }
    }
}
