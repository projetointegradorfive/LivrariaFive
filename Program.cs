using LivrariaFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Controller;

namespace LivrariaFive.View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Livro livro = new Livro(); // Instancia um objeto Livro
            Cliente clienteAtual = new Cliente(); // Instancia um objeto Cliente


            //Application.Run(new LivroForm(clienteAtual));
            Application.Run(new FrmGerenciarLivros());
        }
    }
}
