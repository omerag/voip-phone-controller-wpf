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

        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
            InitObjects();
        }

        private void InitObjects()
        {
            getRequestDispacher = new GetRequestDispatcher("http://localhost", "501");
        }

        void FillDataGrid()
        {
            BindContactList bindContactList = new BindContactList(DataGridXMAL);
            bindContactList.fillData();
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CallBtn(object sender, RoutedEventArgs e)
        {
            string response = getRequestDispacher.SendCall(CallNumberTextbox.Text);
            Console.WriteLine(response);
        }

        private void HangBtn(object sender, RoutedEventArgs e)
        {
            string response = getRequestDispacher.SendHang();
            Console.WriteLine(response);
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

        private void DataGridXMAL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            ContactModel row = (ContactModel)dataGrid.SelectedItems[0];

            CallNumberTextbox.Text = row.CallNumber;

        }

        private void DataGridXMAL_DoubleClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
