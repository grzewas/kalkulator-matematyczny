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

namespace Calc3
{
	
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		
		

		private void kwadrat_Checked(object sender, RoutedEventArgs e)
		{
			a.IsEnabled = true;
			b.IsEnabled = false;
			c.IsEnabled = false;
			d.IsEnabled = false;
			xD.IsEnabled = false;
			
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			a.IsEnabled = true;
			c.IsEnabled = true;
			b.IsEnabled = false;
			d.IsEnabled = false;
			xD.IsEnabled = false;
			
		}

		private void romb_Checked(object sender, RoutedEventArgs e)
		{
			a.IsEnabled = false;
			b.IsEnabled = false;
			c.IsEnabled = false;
			d.IsEnabled = true;
			xD.IsEnabled = true;
		}

		private void rownoleglobok_Checked(object sender, RoutedEventArgs e)
		{
			a.IsEnabled = true;
			c.IsEnabled = true;
			b.IsEnabled = false;
			d.IsEnabled = false;
			xD.IsEnabled = false;
		}

		private void trapez_Checked(object sender, RoutedEventArgs e)
		{
			a.IsEnabled = true;
			b.IsEnabled = true;
			c.IsEnabled = true;
			d.IsEnabled = false;
			xD.IsEnabled = false;
		}

		private void trojkat_Checked(object sender, RoutedEventArgs e)
		{
			a.IsEnabled = true;
			c.IsEnabled = true;
			b.IsEnabled = false;
			d.IsEnabled = false;
			xD.IsEnabled = false;
		}

		private void bResult_Click(object sender, RoutedEventArgs e)
		{
			if (double.Parse(a.Text) < 0 || double.Parse(b.Text) < 0 || double.Parse(c.Text) < 0 || double.Parse(d.Text) < 0 || double.Parse(xD.Text) < 0)
				Wynik.Content = "WPISZ DODATNIE WARTOŚCI!!!";
			else

			if (kwadrat.IsChecked == true)
				Wynik.Content = Math.Round((float.Parse(a.Text)) * (float.Parse(a.Text)), 2);
			else if (prostokat.IsChecked == true)
				Wynik.Content = Math.Round((float.Parse(a.Text)) * (float.Parse(c.Text)), 2);
			else if (romb.IsChecked == true)
				Wynik.Content = Math.Round((float.Parse(d.Text)) * (float.Parse(xD.Text)/2), 2);
			else if (rownoleglobok.IsChecked == true)
				Wynik.Content = Math.Round((float.Parse(a.Text)) * (float.Parse(c.Text)), 2);
			else if (trapez.IsChecked == true)
				Wynik.Content = Math.Round(((float.Parse(a.Text))+(float.Parse(b.Text))) * (float.Parse(c.Text))/2, 2);
			else if (trojkat.IsChecked == true)
				Wynik.Content = Math.Round((float.Parse(a.Text)) * (float.Parse(c.Text))/2, 2);

		}
	}
}
