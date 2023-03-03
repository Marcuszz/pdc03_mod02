using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;


namespace pdc03_mod2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity5 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees { get { return employees; } }

		public activity5 ()
		{
			InitializeComponent ();

			{
				lst.ItemsSource = employees;
				employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", profileImage = "image1.jpg" });
                employees.Add(new employee { DisplayName = "John Dela Cruz", Position = "Vice President", profileImage = "image2.jpg" });
                employees.Add(new employee { DisplayName = "Janno Dela Cruz", Position = "Secretary", profileImage = "image03.jpg" });
            }
		}
	}
}