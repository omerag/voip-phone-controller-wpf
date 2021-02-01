using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace voip_phone_controller_wpf.model
{
    class BindContactList
    {
        public ObservableCollection<ContactModel> ContactsList { get; set; }
        public ListCollectionView ListCollectionView { get; set; }

        public BindContactList()
        {
            ContactsList = new LoadDataFromCSV().LoadData();

            ListCollectionView = new ListCollectionView(ContactsList);
            ListCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("Company"));
        }
    }
}
