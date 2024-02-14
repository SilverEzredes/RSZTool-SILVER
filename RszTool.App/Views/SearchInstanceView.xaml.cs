﻿using System.Windows;
using System.Windows.Controls;
using RszTool.App.ViewModels;

namespace RszTool.App.Views
{
    /// <summary>
    /// SearchInstanceView.xaml 的交互逻辑
    /// </summary>
    public partial class SearchInstanceView : UserControl
    {
        public SearchInstanceView()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DataContext is BaseRszFileViewModel viewModel)
            {
                viewModel.SelectedItem = e.NewValue;
            }
        }

        private void SearchInstanceInput_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
