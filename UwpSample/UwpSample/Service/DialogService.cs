using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpSample.Service
{
    public class DialogService : IDialogService
    {
        Windows.UI.Xaml.Controls.ContentDialog dialog;

        public async void showMessageAsync(string text)
        {
            if(dialog == null)
            {
                dialog = new Windows.UI.Xaml.Controls.ContentDialog();
                dialog.Title = "Title";
                dialog.PrimaryButtonText = "OK";
            }
            dialog.Content = text;
            await dialog.ShowAsync();
        }
    }
}
