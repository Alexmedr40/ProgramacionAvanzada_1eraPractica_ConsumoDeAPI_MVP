using ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.View;
using System.Collections.Generic;
using System.Windows.Forms;
using ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Presenter;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP
{
    public partial class FrmAuthor: Form, IAuthorView
    {
        private AuthorPresenter _presenter; // Instancia del Presentador (Presenter).
        public FrmAuthor()
        {
            InitializeComponent();
            _presenter = new AuthorPresenter(this); // Se crea el Presentador y se le pasa la vista actual.
            btnSearch.Click += (s, e) => _presenter.GetAuthorData(); // Asigna el evento del botón de búsqueda para llamar al método GetAuthorData del Presentador.
        }

        // Propiedad que obtiene el nombre del autor ingresado en la caja de texto.
        public string AuthorName => txtAuthorName.Text.Trim();

        // Método para mostrar la información del autor en un DataGridView.
        public void ShowAuthorInfo(Model.Author author)
        {
            dgvAuthorInfo.Rows.Clear(); // Limpia cualquier fila existente en el DataGridView.
            dgvAuthorInfo.Columns.Clear(); // Limpia las columnas para evitar duplicaciones.

            // Se agregan dos columnas: una para el nombre del campo y otra para el valor.
            dgvAuthorInfo.Columns.Add("Campo", "Campo"); 
            dgvAuthorInfo.Columns.Add("Valor", "Valor"); 

            // Se agregan filas con la información del autor.
            dgvAuthorInfo.Rows.Add("Nombre", author.name);
            dgvAuthorInfo.Rows.Add("Nombres Alternativos", string.Join(", ", author.alternate_names ?? new List<string>()));
            dgvAuthorInfo.Rows.Add("Fecha de Nacimiento", author.birth_date ?? "Desconocida");
            dgvAuthorInfo.Rows.Add("Temas Principales", string.Join(", ", author.top_subjects ?? new List<string>()));
            dgvAuthorInfo.Rows.Add("Obra Más Famosa", author.top_work ?? "No disponible");
            dgvAuthorInfo.Rows.Add("Total de Obras", author.work_count);
            dgvAuthorInfo.Rows.Add("Calificación Promedio", author.ratings_average);
        }

        // Método para mostrar un mensaje de error en caso de que ocurra algún problema.
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
