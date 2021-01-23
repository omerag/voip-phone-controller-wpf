using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace voip_phone_controller_wpf.model
{
    class BindContactList
    {
        public List<ContactModel> ContactsList { get; set; }
        DataGrid dataGrid;

        public BindContactList(DataGrid dataGrid)
        {
            ContactsList = new LoadDataFromCSV().LoadData();
            this.dataGrid = dataGrid;
        }

        public void fillData()
        {
            foreach(ContactModel contact in ContactsList)
            {
                dataGrid.ClearValue(ItemsControl.ItemsSourceProperty);
                dataGrid.Items.Add(contact);
                
            }
        }



    }
}
