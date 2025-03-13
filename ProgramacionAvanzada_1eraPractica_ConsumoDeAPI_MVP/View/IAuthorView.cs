using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.View
{
    public interface IAuthorView
    {
        string AuthorName { get; }  // Obtiene el nombre ingresado por el usuario
        void ShowAuthorInfo(Model.Author author);  // Muestra la información del autor
        void ShowErrorMessage(string message);  // Muestra un mensaje de error
    }
}
