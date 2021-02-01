using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.model
{
    interface ILoadData
    {
        ObservableCollection<ContactModel> LoadData();
    }
}
