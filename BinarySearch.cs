using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure_project_record_company {
    class BinarySearch {
        public static int BinarySearchDisplay(int[] arr, int key) {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max) {
                int mid = (min + max) / 2;

                if (key == arr[mid]) {
                    return mid;
                }
                else if (key > arr[mid]) {
                    min = mid + 1;
                }
                else {
                    max = mid - 1;
                }
            }

            return -1;
        }

        // Esta função é utilizada apenas em funções de interface do sistema, as informações de Canção, Artista e Álbum estão todas em vetores de tamanho fixo
        public static int BinarySearchDisplay(List<int> arr, int key) {
            int min = 0;
            int max = arr.Count - 1;

            while (min <= max) {
                int mid = (min + max) / 2;

                if (key == arr[mid]) {
                    return mid;
                }
                else if (key > arr[mid]) {
                    min = mid + 1;
                }
                else {
                    max = mid - 1;
                }
            }

            return -1;
        }
    }
}
