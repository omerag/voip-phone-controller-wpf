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

        public ListCollectionView GetFilteredListCollectionView(string filter)
        {
            if( filter == null)
            {
                Console.WriteLine("filter = null");

                return ListCollectionView;
            }

            Console.WriteLine("filter = " + filter);

            IEnumerable<ContactModel> query = ContactsList.Where(x => x.Name.ToUpper().StartsWith(filter.ToUpper()));
            ObservableCollection<ContactModel> contactModels = new ObservableCollection<ContactModel>();

            foreach (ContactModel contact in query)
            {
                contactModels.Add(contact);
            }

            ListCollectionView listCollectionView= new ListCollectionView(contactModels);
            listCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("Company"));

            if(contactModels.Count == 0)
            {
                return ListCollectionView;
            }

            return listCollectionView;

        }
    }
}
