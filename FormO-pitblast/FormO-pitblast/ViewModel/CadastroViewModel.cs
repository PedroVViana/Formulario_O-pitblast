using FormO_pitblast.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormO_pitblast.ViewModel
{
    public class CadastroViewModel
    {
        public CadastroCommands Cadastro { get; set; }

        public CadastroViewModel()
        {
            Cadastro = new CadastroCommands();
        }
    }
}
