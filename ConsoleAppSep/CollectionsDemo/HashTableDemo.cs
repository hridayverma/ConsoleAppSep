using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppSep.CollectionsDemo
{
    internal class HashTableDemo
    {
        public static void Main()
        {
            //Hashtable users = new Hashtable();
            SortedList users = new SortedList();
            
            users.Add("user1", "user@123");
            users.Add("admin", "admin@123");
            users.Add("sumit", "sumit@123");
            users.Add("shinde", "shinde@123");
            users.Add("sonal", "sonal@123");
            users.Add("deepti", "deepti@123");
           // users.Add("deepti", "deepti@124");//duplicate & null key not allowed
           // users.Add(null, "null@123");
            Console.WriteLine("Users data:");
            //Console.WriteLine(users["user1"]);
            //using foreach 
            foreach (DictionaryEntry user in users)
            {
                Console.WriteLine(user.Key+"=>"+user.Value);
            }
            //using Enumerator
            IDictionaryEnumerator itr=users.GetEnumerator();
            Console.WriteLine("users data using Enumerator");
            while (itr.MoveNext()) {
                Console.WriteLine(itr.Key+"\t"+itr.Value);
            }

            //getting all keys
            ICollection keys= users.Keys;
            // ArrayList userskeys = new ArrayList(keys);
            IEnumerator keyitr=  keys.GetEnumerator();
            Console.WriteLine("UserNames:");
            while (keyitr.MoveNext()) {
                Console.WriteLine(keyitr.Current);
            }















        }
    }
}
