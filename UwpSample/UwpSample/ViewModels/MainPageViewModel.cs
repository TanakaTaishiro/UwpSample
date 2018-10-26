using Prism.Commands;
using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UwpSample.Service;

namespace UwpSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IDialogService dialogService;
        public IDialogService DialogService
        {
            get { return dialogService; }
            set { this.SetProperty(ref this.dialogService, value); }
        }

        private string messageText;
        public string MessageText
        {
            get { return messageText; }
            set { this.SetProperty(ref this.messageText, value); }
        }


        public DelegateCommand MsgShowCommand { get; }

        public MainPageViewModel()
        {
            this.MsgShowCommand = new DelegateCommand(() =>
            {
                this.dialogService.showMessageAsync(this.MessageText);
            },
            () => string.IsNullOrEmpty(this.MessageText) == false)
            .ObservesProperty(() => this.MessageText);
        }
    }
}
