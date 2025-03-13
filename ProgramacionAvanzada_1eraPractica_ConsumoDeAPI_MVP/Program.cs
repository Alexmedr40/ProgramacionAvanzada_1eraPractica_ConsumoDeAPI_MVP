using ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmAuthor view = new FrmAuthor();

            AuthorPresenter presenter = new AuthorPresenter(view);

            Application.Run(view);
        }
    }
}
