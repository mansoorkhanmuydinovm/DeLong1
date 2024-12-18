﻿using DeLong.WPF.Pages.Customers;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace DeLong.WPF;

#pragma warning disable
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private string _currentLanguage = "en"; // Tanlangan tilni saqlash uchun o'zgaruvchi

    private void LanguageAPP(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        if (languageComboBox.SelectedItem is ComboBoxItem selectedItem)
        {
            string selectedLanguage = selectedItem.Tag.ToString();

            if (_currentLanguage != selectedLanguage) // Faqat til o'zgarishida yangilash
            {
                _currentLanguage = selectedLanguage;
                DeLong.WPF.Resources.Resource.Culture = new CultureInfo(selectedLanguage);
                UpdateLanguage(); // Matnlarni yangilash
            }
        }
    }
    private void UpdateLanguage()
    {


    }

    private void bntMijoz_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
    {

    }

    private void btnChiqish_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void bntMijoz_Click(object sender, RoutedEventArgs e)
    {
        // Navigate to CustomerPage
        Navigator.Navigate(new Pages.Customers.CustomerPage());
    }
}