using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
	class HashTable {
		static int tableSize = 13;
		static int prime = 7;
		static int[] hashTable;
		static int currentSize;

		static HashTable(){
			hashTable = new int[tableSize];
			currentSize = 0;

			for (int i = 0; i < tableSize; i++) {
				hashTable[i] = -1;
			}
		}

		private static bool IsFull(){
			return currentSize == tableSize;
		}

		private static int Hash1(int key){
			return (key % tableSize);
		}

		private static int Hash2(int key){
			return (prime - (key % prime));
		}

		public static void InsertHash(int key){
			if (IsFull()){ 
				MessageBox.Show("O número máximo de e-mails já foi inserido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int index = Hash1(key);

			if(hashTable[index] != -1){
				int index2 = Hash2(key);
				int i = 1;

				while(true){
					int newIndex = (index + i * index2) % tableSize;

					if(hashTable[newIndex] == -1){
						hashTable[newIndex] = key;
						break;
					}

					i++;
				}
			}else{
				hashTable[index] = key;
				currentSize++;
			}
		}
	}
}
