using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Commands;
using UniVoting.Core;
using UniVoting.Services;

namespace Univoting.Admin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IElectionConfigurationService _service;

        public MainWindowViewModel(IElectionConfigurationService service)
        {
            _service = service;
        }



        private string _title = "UNIVOTING ADMIN";

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }


        private string _userName;

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private DelegateCommand<PasswordBox> _loginCommand;
        public DelegateCommand<PasswordBox> LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand<PasswordBox>( async (passwordBox)=> await ExecuteLoginCommand(passwordBox)));

        private async Task ExecuteLoginCommand(PasswordBox passwordBox)
        {
            var password = passwordBox.Password;

            var  result= await _service.LoginAsync(new Commissioner { UserName = _userName, Password = password });
        }

    }
}
