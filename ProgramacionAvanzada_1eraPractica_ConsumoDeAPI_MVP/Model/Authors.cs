using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Model
{
    // Modelo raíz para manejar la respuesta de la API
    public class Authors
    {
        public List<Author> docs { get; set; } // Lista de autores encontrados
    }
}

