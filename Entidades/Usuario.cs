using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        /// <summary>
        /// Obtiene o establece el apellido del usuario.
        /// Obtiene o establece el nombre del usuario.
        /// Obtiene o establece el legajo del usuario.
        /// Obtiene o establece el correo electrónico del usuario.
        /// Obtiene o establece la clave del usuario.
        /// Obtiene o establece el perfil del usuario.
        /// </summary>
        [JsonPropertyName("apellido")]
        public string Apellido { get; set; } = string.Empty;

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("legajo")]
        public int Legajo { get; set; }
 
        [JsonPropertyName("correo")] 
        public string Correo { get; set; } = string.Empty;

        [JsonPropertyName("clave")]
        public string Clave { get; set; } = string.Empty;

        [JsonPropertyName("perfil")]
        public string Perfil { get; set; } = string.Empty;
    }
}
