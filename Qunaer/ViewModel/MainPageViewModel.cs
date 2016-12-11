using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qunaer.ViewModel
{
    public class MainPageViewModel:BaseViewModel
    {
        private ObservableCollection<Model.Book> _tourlist;
        public ObservableCollection<Model.Book> Tourlist
        {
            get
            {
                return _tourlist;
            }
            set
            {
                _tourlist = value;
                RaisePropertyChanged(nameof(Tourlist));
            }
        }
    }
}
