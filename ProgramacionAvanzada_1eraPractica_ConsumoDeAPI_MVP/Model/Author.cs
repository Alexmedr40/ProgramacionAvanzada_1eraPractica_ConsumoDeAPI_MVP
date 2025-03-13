using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Model
{
    // Representa la estructura de los datos que recibimos de la API
    public class Author
    {
        public string key { get; set; }  // Identificador del autor en la API
        public string name { get; set; }  // Nombre del autor
        public List<string> alternate_names { get; set; }  // Nombres alternativos
        public string birth_date { get; set; }  // Fecha de nacimiento
        public List<string> top_subjects { get; set; }  // Temas principales de sus obras
        public string top_work { get; set; }  // Obra más destacada
        public int work_count { get; set; }  // Número de obras publicadas
        public double ratings_average { get; set; }  // Promedio de calificaciones
    }
}
