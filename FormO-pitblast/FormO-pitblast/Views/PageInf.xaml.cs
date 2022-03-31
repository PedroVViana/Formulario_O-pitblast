using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormO_pitblast.Views
{
    /// <summary>
    /// Lógica interna para PageInf.xaml
    /// </summary>
    public partial class PageInf : Window
    {
        public PageInf()
        {
            InitializeComponent();
        }

        public string PropNome { get; set; }
        public string PropIdade { get; set; }
        public string PropEmail { get; set; }
        public string PropHobbies { get; set; }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (!this.PropNome.Equals(""))
            {
                txtNome.Text = this.PropNome;
                
            }
            if (!this.PropIdade.Equals(""))
            {
                txtIdade.Text = this.PropIdade;

            }
            if (!this.PropEmail.Equals(""))
            {
                txtEmail.Text = this.PropEmail;

            }
            if (!this.PropHobbies.Equals(""))
            {
                txtHobbies.Text = this.PropHobbies;

            }
        }
    }
}
