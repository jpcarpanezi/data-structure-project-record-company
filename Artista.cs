using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure_project_record_company
{
    class Artista {
        public enum TipoTrabalho {
            Cantor = 1,
            Compositor = 2,
            Ambos = 3
        }

        public int Codigo { get; set; }
        public string NomeVerdadeiro { get; set; }
        public string NomeArtistico { get; set; }
        public DateTime Aniversario { get; set; }
        public bool BandaBool { get; set; }
        public string NomeBanda { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string NomeEmpresario { get; set; }
        public string EmailEmpresario { get; set; }
        public TipoTrabalho TipoDeTrabalho { get; set; }
        public int NumeroAlbunsLancados { get; set; }
        public int NumeroComposicoes { get; set; }
        public decimal CacheMinimo { get; set; }
    }
}
