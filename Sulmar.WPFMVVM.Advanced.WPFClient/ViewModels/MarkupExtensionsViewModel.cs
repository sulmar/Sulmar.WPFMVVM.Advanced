using Sulmar.WPFMVVM.Advanced.WPFClient.Commands;
using Sulmar.WPFMVVM.Advanced.WPFClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.ViewModels
{
    public class MarkupExtensionsViewModel : BaseViewModel
    {
        private IEnumerable<string> _items;

        public Status SelectedStatus { get; set; } = Status.Completed;


        public IEnumerable<string> Items
        {
            get => _items;
            set
            {
                _items = value;

                OnPropertyChanged();
            }
        }

        public MarkupExtensionsViewModel()
        {
            LoadCommand = new RelayCommand(p => Load());
            SendCommand = new RelayCommand(p => Send(), p => CanSend);


        }

        private void Load()
        {
            Items = Enumerable.Range(1, 10000).Select(x => $"Item {x}");
        }

        private void Send()
        {
            SelectedStatus = Status.Completed;
        }

        private bool CanSend => SelectedStatus == Status.InProgress;

        public ICommand LoadCommand { get; set; }
        public ICommand SendCommand { get; set; }


    }
}
