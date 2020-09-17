using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;

namespace data_structure_project_record_company {
	class HashTable {
		public static void HashMain(){
			String[] values = new string[50];
			String str;
			int hashCode;

			String[] keys = new String[]{
				"jpcarpanezi@gmail.com", "jp@proativa.info", "prof.raul@ifsp.edu.br", "jpcarpanezi@hotmail.com"
			};	

			for (int i = 0; i < keys.Length; i++) {
				str = keys[i];

				hashCode = Hash(str, values);
				values[hashCode] = str;
			}
		}

		public static int Hash(String s, String[] arr){
			long total = 0;
			char[] c;
			c = s.ToCharArray();

			for (int i = 0; i <= c.GetUpperBound(0); i++) {
				total += 11 * total + (int)c[i];
			}

			total = total % arr.GetUpperBound(0);

			if(total < 0){
				total += arr.GetUpperBound(0);
			}

			return (int)total;
		}
	}
}
