using CV23.Infrostructure.Commands;
using CV23.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace CV23.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Свойства

        #region Title: string - Заголовок окна
        /// <summary>Заголовок окна</summary>
        private string _Title = "CV23";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status: string - Статус программы
        /// <summary>Статус программы</summary>
        private string _Status = "Готово!";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #endregion

        #region Команды

        #region Закрыть окно прилоения
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p) 
        {
            Application.Current.Shutdown();
        }
        #endregion


        #endregion

        public MainWindowViewModel()
        {

            #region Комманды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            
            #endregion
        }
    }
}
