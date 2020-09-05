using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure_project_record_company
{
    class Album {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int[] CodigosMusicas { get; set; }
        public DateTime DataLancamento { get; set; }
        public long NumeroCopiasVendidas { get; set; }
        public string[] ArtistasParticipantes { get; set; }
    }
}
