using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using FormO_pitblast.Views;
using FormO_pitblast.ViewModel;
using System.Windows.Forms;


namespace FormO_pitblast.Commands
{
    public class CadastroCommands : ICommand

    {
     

        public object MessagemBox { get; private set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var telaInf = new Informacao();
            telaInf.Show();

        
        }

    }
}
