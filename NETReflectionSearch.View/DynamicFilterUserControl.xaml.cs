using System;
using System.Windows;
using System.Windows.Controls;
using NETReflectionSearch.Model;

namespace NETReflectionSearch.View
{
	/// <summary>
	/// Interaction logic for DynamicFilterUserControl.xaml
	/// </summary>
	public partial class DynamicFilterUserControl : UserControl
	{
		public DynamicFilterUserControl()
		{
			InitializeComponent();
			FilterProvider = new SearchFilterProvider();

			foreach (var filterDescription in FilterProvider.FilterDescriptions)
			{
				FiltersComboBox.Items.Add(filterDescription);
			}
		}

		SearchFilterProvider FilterProvider { get; }
		internal SearchFilter Filter { get; private set; }

		private void FiltersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Filter = FilterProvider.CreateNewFilterFromDescription((string)FiltersComboBox.SelectedItem);

			var textFilter = Filter as ITextFilter;

			if (textFilter != null)
			{
				FlagColumnDef.Width = new GridLength(0);
				FilterText.Text = textFilter.Text;
				return;
			}

			var textFilterWithFlag = Filter as ITextFilterWithFlag;

			if (textFilterWithFlag != null)
			{
				FlagColumnDef.Width = new GridLength(180);
				FilterFlag.Content = textFilterWithFlag.FlagDescription;
				FilterText.Text = textFilterWithFlag.Text;
				return;
			}

			throw new NotSupportedException($"Unexpected filter type: {Filter.GetType().FullName}");
		}
	}
}
