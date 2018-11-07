using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RelayCommandMvvm.Annotations;

namespace RelayCommandMvvm.ViewModel
{
    class ViewModel 
    {
        // Source property which hold the List Data
        // The View ListView (target property) bind this source property (ListData)
        public ObservableCollection<string> ListData { get; set; }

        //  View Add Item Button will bind to this property
        public RelayCommand AddItemCommand { get; set; }

        public ViewModel()
        {
             // create default data in the List
             ListData = new ObservableCollection<string>()
             {
                 "Item1", "Item2","Item3"
             };

            // set up the action for the command 
            AddItemCommand = new RelayCommand(DoAddItem);
        }

        public void DoAddItem(object itemText)
        {
            var newItem = itemText as string;
            if (string.IsNullOrEmpty(newItem))
            {
                newItem = "Item" + ListData.Count;
            }
            ListData.Add(newItem);
        }

       
    }
}
