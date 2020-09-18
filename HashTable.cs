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
		public static void InsertQuadraticHashing(int[] table, int tsize, int[] arr, int N){
			for (int i = 0; i < N; i++) {
				int hv = arr[i] % tsize;

				if(table[hv] == -1){
					table[hv] = arr[i];
				}else{
					for(int j = 0; j < tsize; j++){
						int t = (hv + j * j) % tsize;
						if(table[t] == -1){
							table[t] = arr[i];
							break;
						}
					}
				}
			}
		}
	}
}
