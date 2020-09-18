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
		int key;
		string data;

		public HashEntry(int key, String data) {
			this.key = key;
			this.data = data;
		}

		public int GetKey() {
			return key;
		}

		public String GetData() {
			return data;
		}
	}

	class HashTable {
		private const int maxSize = 4;
		static HashEntry[] table;

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

		public static String Retrive(int key) {
			int hash = key % maxSize;
			while (table[hash] != null && table[hash].GetKey() != key) {
				hash = (hash + 1) % maxSize;
			}

			if (table[hash] == null) {
				return "Nada encontrado";
			} else {
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
			} else {
				table[hash] = null;
				return true;
			}
		}

		public static String Print() {
			// Usando apenas para breakpoint de debug
			for (int i = 0; i < table.Length; i++) {
				if (table[i] == null && i <= maxSize) {
					continue;
				} else {
					table[i].GetData();
				}
			}

			return table.ToString();
		}

		private static int Hash1(int key) {
			return key % maxSize;
		}

		private static int Hash2(int key) {
			return 5 - key % 5;
		}

		public static void Insert(int key, String data) {
			int hash = (key % maxSize);

			if (!CheckOpenSpace()) {
				MessageBox.Show("Tabela hash está cheia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			while (table[hash] != null && table[hash].GetKey() != key) {
				hash = (hash + 1) % maxSize;
			}

			table[hash] = new HashEntry(key, data);
		}

		public static void QuadraticHashInsert(int key, String data) {
			int i = 0;
			int hash = key % maxSize;

			if (!CheckOpenSpace()) {
				MessageBox.Show("Tabela hash está cheia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			while (table[hash] != null && table[hash].GetKey() != key) {
				i++;
				hash = (hash + i * i) % maxSize;
			}

			if (table[hash] == null) {
				table[hash] = new HashEntry(key, data);
				return;
			}
		}

		public static void DoubleHashInsert(int key, String data) {
			int hashVal = Hash1(key);
			int stepSize = Hash2(key);

			if (!CheckOpenSpace()) {
				MessageBox.Show("Tabela hash está cheia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			while (table[hashVal] != null && table[hashVal].GetKey() != key) {
				hashVal = (hashVal + stepSize * Hash2(key)) % maxSize;
			}

			table[hashVal] = new HashEntry(key, data);
			return;
		}
	}
}
