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
    public class MarkupExtensionsViewModel
    {
        public Status SelectedStatus { get; set; } = Status.Completed;

        public MarkupExtensionsViewModel()
        {
            LoadCommand = new RelayCommand(p => Load());
            SendCommand = new RelayCommand(p => Send(), p => CanSend);
        }

        private void Load()
        {
            
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
