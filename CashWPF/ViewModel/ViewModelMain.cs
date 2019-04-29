using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashWPF.Model;

namespace CashWPF.ViewModel
{
    class ViewModelMain
    {
        public ObservableCollection<SalesItem> TransacItem { get; set; }

        public ViewModelMain()
        {
            TransacItem = new ObservableCollection<SalesItem>();
        }
    }

  
}
