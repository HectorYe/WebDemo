using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WebDemo.ViewModel
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {
        public ICommand ExportDataCommand
        {
            get
            {
                return new Command.RelayCommand(param =>
                {
                    //程式碼寫在這裡!
                });
            }
        }
        public ICommand ExportReportCommand
        {
            get
            {
                return new Command.RelayCommand(ParamArrayAttribute =>
                {
                    //程式碼寫在這裡!!!
                });
            }
        }
    }
}
