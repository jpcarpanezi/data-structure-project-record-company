using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace data_structure_project_record_company {
	class MergeSort {
        private static Array GenArray;
        private static int[] Codigos;
        private static DateTime[] CodigosDt;
		private static int Length;

        private static void Merge(int left, int middle, int right) {
            int[] leftArray = new int[middle - left + 1];
            object[] leftGenArray = new object[middle - left + 1];
            int[] rightArray = new int[right - middle];
            object[] rightGenArray = new object[right - middle];

            Array.Copy(Codigos, left, leftArray, 0, middle - left + 1);
            Array.Copy(GenArray, left, leftGenArray, 0, middle - left + 1);
            Array.Copy(Codigos, middle + 1, rightArray, 0, right - middle);
            Array.Copy(GenArray, middle + 1, rightGenArray, 0, right - middle);

            int i = 0, j = 0;
            for (int k = left; k < right + 1; k++) {
                if (i == leftArray.Length) {
                    Codigos[k] = rightArray[j];
                    GenArray.SetValue(rightGenArray[j], k);
                    j++;
                }
                else if (j == rightArray.Length) {
                    Codigos[k] = leftArray[i];
                    GenArray.SetValue(leftGenArray[i], k);
                    i++;
                }
                else if (leftArray[i] <= rightArray[j]) {
                    Codigos[k] = leftArray[i];
                    GenArray.SetValue(leftGenArray[i], k);
                    i++;
                }
                else {
                    Codigos[k] = rightArray[j];
                    GenArray.SetValue(rightGenArray[j], k);
                    j++;
                }
            }
        }

        private static void MainSort(int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                MainSort(left, middle);
                MainSort(middle + 1, right);

                Merge(left, middle, right);
            }
        }

        public static void Sort(Array array, int[] keys) {
            GenArray = array;
            Codigos = keys;
            Length = Codigos.Where(a => a > 0).Count() - 1;

            MainSort(0, Length);
        }


        // String Sort
        public static void Sort(string[] array) {
            Length = array.Length - 1;

            MainSort(array, 0, Length);
        }

        private static void Merge(string[] array, int left, int middle, int right) {
            string[] leftGenArray = new string[middle - left + 1];
            string[] rightGenArray = new string[right - middle];

            Array.Copy(array, left, leftGenArray, 0, middle - left + 1);
            Array.Copy(array, middle + 1, rightGenArray, 0, right - middle);

            int i = 0, j = 0;
            for (int k = left; k < right + 1; k++) {
                if (i == leftGenArray.Length) {
                    array[k] = rightGenArray[j];
                    j++;
                }
                else if (j == rightGenArray.Length) {
                    array[k] = leftGenArray[i];
                    i++;
                }
                else if (leftGenArray[i].ElementAt(0) <= rightGenArray[j].ElementAt(0)) { // ElementAt pega o char no indice passado para funcao
                    array[k] = leftGenArray[i];
                    i++;
                }
                else {
                    array[k] = rightGenArray[j];
                    j++;
                }
            }
        }

        private static void MainSort(string[] array, int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                MainSort(array, left, middle);
                MainSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        // DateTime Sort
        public static void Sort(Array array, DateTime[] keys) {
            GenArray = array;
            CodigosDt = keys;
            Length = CodigosDt.Where(a => a != DateTime.MinValue).Count() - 1;

            MainSortDt(0, Length);
        }

        private static void MainSortDt(int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                MainSortDt(left, middle);
                MainSortDt(middle + 1, right);

                MergeDt(left, middle, right);
            }
        }

        private static void MergeDt(int left, int middle, int right) {
            DateTime[] leftArray = new DateTime[middle - left + 1];
            object[] leftGenArray = new object[middle - left + 1];
            DateTime[] rightArray = new DateTime[right - middle];
            object[] rightGenArray = new object[right - middle];

            Array.Copy(CodigosDt, left, leftArray, 0, middle - left + 1);
            Array.Copy(GenArray, left, leftGenArray, 0, middle - left + 1);
            Array.Copy(CodigosDt, middle + 1, rightArray, 0, right - middle);
            Array.Copy(GenArray, middle + 1, rightGenArray, 0, right - middle);

            int i = 0, j = 0;
            for (int k = left; k < right + 1; k++) {
                if (i == leftArray.Length) {
                    CodigosDt[k] = rightArray[j];
                    GenArray.SetValue(rightGenArray[j], k);
                    j++;
                }
                else if (j == rightArray.Length) {
                    CodigosDt[k] = leftArray[i];
                    GenArray.SetValue(leftGenArray[i], k);
                    i++;
                }
                else if (leftArray[i] <= rightArray[j]) {
                    CodigosDt[k] = leftArray[i];
                    GenArray.SetValue(leftGenArray[i], k);
                    i++;
                }
                else {
                    CodigosDt[k] = rightArray[j];
                    GenArray.SetValue(rightGenArray[j], k);
                    j++;
                }
            }
        }
    }
}
