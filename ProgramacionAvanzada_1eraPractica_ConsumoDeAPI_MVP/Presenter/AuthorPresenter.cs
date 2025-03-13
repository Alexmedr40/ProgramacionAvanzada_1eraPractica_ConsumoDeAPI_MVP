using ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Model;
using ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Presenter
{
    public class AuthorPresenter
    {
        private readonly IAuthorView _view; // Referencia a la vista
        private readonly AuthorService _service; // Referencia al servicio que maneja las llamadas a la API

        public AuthorPresenter(IAuthorView view)
        {
            _view = view;
            _service = new AuthorService();
        }


        // Método para obtener los datos del autor según el nombre ingresado en la vista.
        public async void GetAuthorData()
        {
            // Verificar si el usuario ingresó un nombre de autor
            if (string.IsNullOrWhiteSpace(_view.AuthorName))
            {
                _view.ShowErrorMessage("Por favor, ingrese un nombre de autor."); // Muestra un mensaje de error en la vista
                return;
            }

            // Llamada al servicio para obtener la información del autor desde la API
            var data = await _service.GetAuthorInfo(_view.AuthorName);

            // Verificar si se encontraron datos en la API
            if (data != null && data.docs.Count > 0)
            {
                _view.ShowAuthorInfo(data.docs[0]);  // Enviar el primer resultado encontrado a la vista
            }
            else
            {
                _view.ShowErrorMessage("No se encontró información del autor."); // Mensaje si no hay resultados
            }
        }
    }
}
