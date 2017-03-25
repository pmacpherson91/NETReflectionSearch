﻿using System.Linq;
using System.Windows;
using System.Windows.Controls;
using NETReflectionSearch.Model;

namespace NETReflectionSearch.View
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void AddFilterButton_Click(object sender, RoutedEventArgs e)
		{
			var filterControl = new DynamicFilterUserControl();
			FiltersStackPanel.Children.Add(filterControl);
			filterControl.RemoveFilterButton.Click += CreateRemoveClickHandler(filterControl);
		}

		RoutedEventHandler CreateRemoveClickHandler(DynamicFilterUserControl control)
		{
			RoutedEventHandler handler = null;
			handler = (s, e) =>
			{
				FiltersStackPanel.Children.Remove(control);
				((Button)s).Click -= handler;
			};

			return handler;
		}

		private void SearchButton_Click(object sender, RoutedEventArgs e)
		{
			var results = new SearchHeader().Search(DirectoryText.Text.Split(','), FiltersStackPanel.Children.OfType<DynamicFilterUserControl>().Select(x => x.Filter));
		}
	}
}
