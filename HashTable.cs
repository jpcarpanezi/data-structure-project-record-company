using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    class HashEntry {
        private readonly int key;
        private readonly string data;

        public HashEntry(int key, string data) {
            this.key = key;
            this.data = data;
        }

        public int GetKey() {
            return key;
        }

        public string GetData() {
            return data;
        }
    }

    class HashTable {
        private const int maxSize = General.MaxSize;
        static readonly HashEntry[] table;

        static HashTable() {
            table = new HashEntry[maxSize];
            for (int i = 0; i < maxSize; i++) {
                table[i] = null;
            }
        }

        private static bool CheckOpenSpace() {
            bool isOpen = false;
            for (int i = 0; i < maxSize; i++) {
                if (table[i] == null) {
                    isOpen = true;
                }
            }

            return isOpen;
        }

        public static string Retrive(int key) {
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].GetKey() != key) {
                hash = (hash + 1) % maxSize;
            }

            if (table[hash] == null) {
                return "Nada encontrado";
            }
            else {
                return table[hash].GetData();
            }
        }

        public static bool Remove(int key) {
            int hash = key % maxSize;

            while (table[hash] != null && table[hash].GetKey() != key) {
                hash = (hash + 1) % maxSize;
            }

            if (table[hash] == null) {
                return false;
            }
            else {
                table[hash] = null;
                return true;
            }
        }

        public static void Edit(int key, string newValue) {
            int hash = key % maxSize;

            while (table[hash] != null && table[hash].GetKey() != key) {
                hash = (hash + 1) % maxSize;
            }

            table[hash] = new HashEntry(key, newValue);
        }

        public static string Print() {
            // Usando apenas para breakpoint de debug
            for (int i = 0; i < table.Length; i++) {
                if (table[i] == null) {
                    continue;
                }
                else {
                    table[i].GetData();
                }
            }

            return table.ToString();
        }

        public static string[] GetAllValues() {
            List<string> tableV = new List<string>();
            for (int i = 0; i < table.Length; i++) {
                if (table[i] == null) {
                    continue;
                }
                else {
                    tableV.Add(table[i].GetData());
                }
            }

            return tableV.ToArray();
        }

        private static int Hash1(int key) {
            return key % maxSize;
        }

        private static int Hash2(int key) {
            return 5 - key % 5;
        }

        public static void Insert(int key, string data) {
            int hash = (key % maxSize);

            if (!CheckOpenSpace()) {
                throw new OutOfMemoryException();
            }

            while (table[hash] != null && table[hash].GetKey() != key) {
                hash = (hash + 1) % maxSize;
            }

            table[hash] = new HashEntry(key, data);
        }

        public static int QuadraticHashInsert(string data) {
            int key = new Random().Next(0, 100);
            int i = 0;
            int hash = key % maxSize;

            if (!CheckOpenSpace()) {
                throw new OutOfMemoryException();
            }

            while (table[hash] != null && table[hash].GetKey() != key) {
                i++;
                hash = (hash + i * i) % maxSize;
            }

            if (table[hash] == null) {
                table[hash] = new HashEntry(key, data);
                return hash;
            }

            return -1;
        }

        public static void DoubleHashInsert(int key, string data) {
            int hashVal = Hash1(key);
            int stepSize = Hash2(key);

            if (!CheckOpenSpace()) {
                throw new OutOfMemoryException();
            }

            while (table[hashVal] != null && table[hashVal].GetKey() != key) {
                hashVal = (hashVal + stepSize * Hash2(key)) % maxSize;
            }

            table[hashVal] = new HashEntry(key, data);
            return;
        }
    }
}
