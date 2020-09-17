using Microsoft.VisualBasic.CompilerServices;
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

        public static void Sort(Array array, int[] keys) {
            GenArray = array;
            Codigos = keys;
            Length = Codigos.Where(a => a > 0).Count() - 1;

            MainSort(0, Length);
        }

        private static void MainSort(int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                MainSort(left, middle);
                MainSort(middle + 1, right);

                Merge(left, middle, right);
            }
        }

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

        // String Sort
        public static void Sort(Array array, string[] str) {
            GenArray = array;
            Length = str.Length - 1;

            MainSort(str, 0, Length);
        }

        private static void MainSort(string[] array, int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                MainSort(array, left, middle);
                MainSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        private static void Merge(string[] str, int left, int middle, int right) {
            string[] leftArray = new string[middle - left + 1];
            object[] leftGenArray = new object[middle - left + 1];
            string[] rightArray = new string[right - middle];
            object[] rightGenArray = new object[right - middle];

            Array.Copy(str, left, leftArray, 0, middle - left + 1);
            Array.Copy(GenArray, left, leftGenArray, 0, middle - left + 1);
            Array.Copy(str, middle + 1, rightArray, 0, right - middle);
            Array.Copy(GenArray, middle + 1, rightGenArray, 0, right - middle);

            int i = 0, j = 0;
            for (int k = left; k < right + 1; k++) {
                if (i == leftArray.Length) {
                    str[k] = rightArray[j];
                    GenArray.SetValue(rightGenArray[j], k);
                    j++;
                }
                else if (j == rightArray.Length) {
                    str[k] = leftArray[i];
                    GenArray.SetValue(leftGenArray[i], k);
                    i++;
                }
                else if (leftArray[i].CompareTo(rightArray[j]) <= 0) {
                    str[k] = leftArray[i];
                    GenArray.SetValue(leftGenArray[i], k);
                    i++;
                }
                else {
                    str[k] = rightArray[j];
                    GenArray.SetValue(rightGenArray[j], k);
                    j++;
                }

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
