using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RowDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


			var data = new[] {
							new {
								name = "Arsenio Alston",
								phone = "1-477-674-1878",
								email = "et@yahoo.net",
								address = "590-1213 Justo. Avenue",
								country = "Pakistan"
							},
							new {
								name = "Naida Sherman",
								phone = "(884) 183-7890",
								email = "imperdiet.ornare@protonmail.edu",
								address = "Ap #387-2390 Elit, St.",
								country = "Ireland"
							},
							new {
								name = "Suki Morrow",
								phone = "1-551-808-3145",
								email = "tincidunt@protonmail.edu",
								address = "Ap #921-1867 Pede, Rd.",
								country = "Germany"
							},
							new {
								name = "Piper Whitney",
								phone = "(886) 587-7769",
								email = "pharetra.sed@protonmail.net",
								address = "P.O. Box 708, 3739 Donec Rd.",
								country = "Peru"
							},
							new {
								name = "Jessica Burton",
								phone = "1-737-663-1104",
								email = "neque@google.ca",
								address = "189-1083 Mus. St.",
								country = "India"
							}
						};

			MyGrid.ItemsSource = data;

		}

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton == MouseButton.Left)
            {
				var row = e.Source as DataGridRow;

				DetailsWindow detailsWindow = new DetailsWindow(row.Item);
				detailsWindow.Owner = this;

				detailsWindow.Show();


            }





        }
    }
}
