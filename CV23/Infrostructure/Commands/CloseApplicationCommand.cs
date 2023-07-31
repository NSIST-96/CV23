using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV23.Infrostructure.Commands
{
    internal class CloseApplicationCommand : Base.Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter) => App.Current.Shutdown();
    }
}
