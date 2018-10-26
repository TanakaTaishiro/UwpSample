using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpSample.Service
{
    public interface IDialogService
    {
        void showMessageAsync(string text);
    }
}
