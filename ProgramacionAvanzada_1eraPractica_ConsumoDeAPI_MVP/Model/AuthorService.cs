using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada_1eraPractica_ConsumoDeAPI_MVP.Model
{
    public class AuthorService
    {
        // URL base de la API para buscar autores en OpenLibrary
        private const string ApiUrl = "https://openlibrary.org/search/authors.json?q=";

        public async Task<Authors> GetAuthorInfo(string authorName)
        {
            // Se crea una instancia de HttpClient para realizar la solicitud HTTP
            using (HttpClient client = new HttpClient())
            {
                //Se Construye la URL con el nombre del autor (escapado para evitar problemas con espacios u otros caracteres)
                string url = ApiUrl + Uri.EscapeDataString(authorName);

                // Se envía una solicitud GET a la API
                HttpResponseMessage response = await client.GetAsync(url);

                // Si la respuesta es exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta en formato JSON
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserializar el JSON en un objeto Authors y retornarlo
                    return JsonConvert.DeserializeObject<Authors>(jsonResponse);
                }
                else
                {
                    // Si la respuesta no es exitosa, se retorna null
                    return null;
                }
            }
        }
    }
}
