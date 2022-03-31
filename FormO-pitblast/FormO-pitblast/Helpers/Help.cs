using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FormO_pitblast.Helpers
{

    public static class Help
    {
       
        public static void FecharTelaCadastro()
        {
            var tela = Application.Current.MainWindow;
            tela.Close();
        }


    }
}
