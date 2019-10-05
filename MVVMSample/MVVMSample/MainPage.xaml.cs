using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSample.ViewModel;
using Xamarin.Forms;

namespace MVVMSample
{
	public partial class MainPage : ContentPage
	{
        private PersonViewModel ViewModel { get; set; }
        public MainPage()
		{
			InitializeComponent();

            this.ViewModel = new PersonViewModel();
            this.BindingContext = this.ViewModel;
        }
	}
}
