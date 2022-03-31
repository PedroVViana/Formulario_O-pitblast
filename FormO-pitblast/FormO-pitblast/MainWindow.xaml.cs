using FormO_pitblast.Helpers;
using FormO_pitblast.ViewModel;
using FormO_pitblast.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextBox = System.Windows.Forms.TextBox;

namespace FormO_pitblast
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CadastroViewModel();
        }



        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            tb_name.Text = String.Empty;
            tb_idade.Text = String.Empty;
            tb_email.Text = String.Empty;
            tb_Hobbies.Text = String.Empty;
        }

        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
           if (tb_name.Text == "")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Campos devem ser preenchidos", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_name.Focus();
                return;
            }
            if (tb_idade.Text == "")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Campos devem ser preenchidos", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_idade.Focus();
                return;
            }
            if (tb_email.Text == "")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Campos devem ser preenchidos", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_email.Focus();
                return;
            }
            if (tb_Hobbies.Text == "")
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Campos devem ser preenchidos", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Hobbies.Focus();
                return;
            }
            else
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Cadastrado feito com sucesso", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var tela = new PageInf();
                tela.PropNome = tb_name.Text;
                tela.PropIdade = tb_idade.Text;
                tela.PropEmail = tb_email.Text;
                tela.PropHobbies = tb_Hobbies.Text;
                tela.Show();
                Helpers.Help.FecharTelaCadastro();
            }
            
        }

     
    }
}
