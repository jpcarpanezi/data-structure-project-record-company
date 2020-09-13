using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_structure_project_record_company {
	class General {
        public static Album[] Albums;
        public static int AlbumsSize;
        public static Artista[] Artistas;
        public static int ArtistasSize;
        public static Cancao[] Cancoes;
        public static int CancoesSize;
        public static int MaxSize = 10000;

        public struct Album {
            public int Codigo { get; set; }
            public string Titulo { get; set; }
            public int[] CodigosMusicas { get; set; }
            public DateTime DataLancamento { get; set; }
            public long NumeroCopiasVendidas { get; set; }
            public int[] ArtistasParticipantes { get; set; }

            public static void RemoveAt(int index) {
                Album temp = Albums[index];
                Albums = Albums.Where((a, idx) => idx != index).ToArray();
                Array.Resize(ref Albums, MaxSize);
            }
        }

        public struct Artista {
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

            public static void RemoveAt(int index) {
                Artista temp = Artistas[index];
                Artistas = Artistas.Where((a, idx) => idx != index).ToArray();
                Array.Resize(ref Artistas, MaxSize);
            }
        }

        public struct Cancao {
            public int Codigo { get; set; }
            public string Titulo { get; set; }
            public string Letra { get; set; }
            public string Melodia { get; set; }
            public int CodigoCompositor { get; set; }
            public int CodigoArtistaPrimeiraGravacao { get; set; }

            public static void RemoveAt(int index) {
                Cancoes = Cancoes.Where((a, idx) => idx != index).ToArray();
                Array.Resize(ref Cancoes, MaxSize);
            }
        }

    }
}
