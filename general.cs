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
        public const int MaxSize = 10000;

        public struct Album {
            public int Codigo { get; set; }
            public string Titulo { get; set; }
            public int[] CodigosMusicas { get; set; }
            public DateTime DataLancamento { get; set; }
            public long NumeroCopiasVendidas { get; set; }
            public int[] ArtistasParticipantes { get; set; }

            public static void RemoveAt(int index) {
                int i = index;
                for (; i < AlbumsSize - 1; i++) {
                    Albums[i] = Albums[i + 1];
                }
                Albums[i] = new Album();
                AlbumsSize--;
            }

            public static void RemoverMusica(int codigo) {
                for (int i = 0; i < AlbumsSize; i++) {
                    if (Albums[i].CodigosMusicas.Contains(codigo)) {
                        RemoveAt(i);
                        i--;
                    }
                }
            }

            public static void RemoverArtista(int codigo) {
                for (int i = 0; i < AlbumsSize; i++) {
                    if (Albums[i].ArtistasParticipantes.Contains(codigo)) {
                        RemoveAt(i);
                        i--;
                    }
                }
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
            public int EmailEmpresarioTabelaHash { get; set; }
            public TipoTrabalho TipoDeTrabalho { get; set; }
            public int NumeroAlbunsLancados { get; set; }
            public int NumeroComposicoes { get; set; }
            public decimal CacheMinimo { get; set; }

            public static void RemoveAt(int index) {
                Artistas = Artistas.Where((a, idx) => idx != index).ToArray();
                ArtistasSize--;
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
                CancoesSize--;
                Array.Resize(ref Cancoes, MaxSize);
            }

            public static void RemoverArtista(int codigo) {
                for (int i = 0; i < CancoesSize; i++) {
                    if (Cancoes[i].CodigoCompositor == codigo || Cancoes[i].CodigoArtistaPrimeiraGravacao == codigo) {
                        RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}
