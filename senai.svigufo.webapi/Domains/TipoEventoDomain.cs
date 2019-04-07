﻿using System.ComponentModel.DataAnnotations;

namespace senai.svigufo.webapi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Tipo Evento
    /// </summary>
    public class TipoEventoDomain
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do Tipo de Evento")]
        public string Nome { get; set; }
    }
}
