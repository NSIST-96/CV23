using CV23.ViewModels.Base;

namespace CV23.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        /// <summary>Заголовок окна</summary>
        private string _Title = "CV23";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
