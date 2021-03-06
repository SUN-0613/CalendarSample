﻿using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace CalendarSample.Pages.View
{

    /// <summary>
    /// Calendar.View
    /// </summary>
    public partial class Calendar : Page, IDisposable
    {

        /// <summary>
        /// Calendar.View
        /// </summary>
        public Calendar()
        {

            InitializeComponent();

            if (DataContext is ViewModel.Calendar viewModel)
            {
                viewModel.PropertyChanged += OnPropertyChanged;
            }

        }

        /// <summary>
        /// 終了処理
        /// </summary>
        public void Dispose()
        {

            if (DataContext is ViewModel.Calendar viewModel)
            {
                viewModel.PropertyChanged -= OnPropertyChanged;
            }

        }

        /// <summary>
        /// ViewModelプロパティ変更イベント
        /// </summary>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            switch (e.PropertyName)
            {
                default:
                    break;
            }

        }

    }
}
