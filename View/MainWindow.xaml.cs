﻿using System.Threading.Tasks;
using System.Windows;

namespace View
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ViewModel.ViewModel ViewModel { set; get; }

		public MainWindow()
		{
			ViewModel = new ViewModel.ViewModel();
			DataContext = ViewModel;

			InitializeComponent();
		}

		private void CountClick(object sender, RoutedEventArgs e)
		{
			Task taskCount = new Task(() =>
			{
				ViewModel.Count();
				PlotView.InvalidatePlot(true);
			});
			taskCount.Start();
		}

		private void ExampleClick(object sender, RoutedEventArgs e)
		{
			ViewModel.ExampleFill();
		}
	}
}
