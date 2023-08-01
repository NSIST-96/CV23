using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV23_Test.ViewModels
{
    internal class MainWindowViewModel : Base.ViewModel
    {
        #region Свойства

        #region Заголовок окна
        private string _Title = "CV23_Test";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #endregion
        public MainWindowViewModel() { }
    }
}
