using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using voip_phone_controller_wpf.control;
using voip_phone_controller_wpf.model;
using voip_phone_controller_wpf.test;

namespace voip_phone_controller_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private GetRequestDispatcher getRequestDispacher;
        private PhoneSelector phoneData;
        private BindContactList bindContactList;

        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
            InitObjects();
        }

        private void InitObjects()
        {
            getRequestDispacher = new GetRequestDispatcher();
            phoneData = new PhoneSelector(this);
        }

        void FillDataGrid()
        {
            bindContactList = new BindContactList();
            DataGridXMAL.ItemsSource = bindContactList.ListCollectionView;
            //bindContactList.fillData();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }


        private async void CallBtnAsync(object sender, RoutedEventArgs e)
        {
            phoneData.setPhoneData();
            await getRequestDispacher.SendCall(phoneData.ip, phoneData.number, CallNumberProcessor.ProcessPhoneNumber(CallNumberTextbox.Text));
            //Console.WriteLine(response);
        }

        private async void HangBtnAsync(object sender, RoutedEventArgs e)
        {
         
            phoneData.setPhoneData();
            await getRequestDispacher.SendHangAsync(phoneData.ip);
            //Console.WriteLine(response);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void ClearTextbox(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            //Set the text box for numbers only
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void DataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            ContactModel row = (ContactModel)dataGrid.SelectedItems[0];

            CallNumberTextbox.Text = row.CallNumber;

        }

        public void DataGridXMAL_DoubleClick(object sender, RoutedEventArgs e)
        {

        }

        private void RadioBtnClick(object sender, RoutedEventArgs e)
        {
            //RadioButton radioButton = sender as RadioButton;

            //radioButton.IsChecked = true;
        }

        private void SearchNumberTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if(sender != null)
            {
                TextBox textBox = sender as TextBox;
                DataGridXMAL.ItemsSource = bindContactList.GetFilteredListCollectionView(textBox.Text);
            }
        }
    }
}
