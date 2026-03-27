using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace Collections_in_C
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Array list
            //ArrayList arrList = new ArrayList();
            //arrList.Add(2);
            //arrList.Add("ali");
            //arrList.Add(null);
            //arrList.Add(2.3);


            //int[] values = new[] {2, 3, 4 };
            //arrList.AddRange(values);
            //string[] names = { "name1", "name2", "name3" };
            //arrList.AddRange(names);

            ////or

            ////arrList.AddRange(new[] { 1, 2, 3 });

            //arrList.Insert(1, "adding a string");

            //arrList.InsertRange(2, names);

            //arrList.RemoveAt(3);


            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}







            // hashtables

            //Hashtable ht = new Hashtable();
            //ht.Add(1, "john");
            //ht.Add(2, 134);
            //ht.Add(2.1, "string");
            //ht.Add(2.2, "Max");
            //ht.Add(true, 23);
            //ht.Add(false, true);

            //ht.Remove(2.1);
            ////foreach(var item in ht)
            ////{
            ////    var entry = (DictionaryEntry)item;
            ////    Console.WriteLine(entry.Key +""+ entry.Value); 
            ////}

            //foreach (var item in ht)
            //{
            //    var entry = (DictionaryEntry)item;
            //    Console.WriteLine($"Key: {entry.Key} | Value: {entry.Value}");
            //}

            //Console.WriteLine(ht.ContainsKey(1.1));
            //Console.WriteLine(ht.ContainsValue(1));


            //interpolation
            //string a = "ali";
            //string b = "20";
            //Console.WriteLine($"my name is {a} and age is {b}");




            //_________________________________________________________________________________________________________________________


            //generic collections           strongly typed
            //list

            //List<string> food = new List<string>();

            //food.Add("Piza");
            //food.Add("burger");
            //food.Add("hotdog");
            //food.Add("fries");

            //food.Remove("fries");

            //Console.WriteLine(food.Count); 

            //Console.WriteLine(food.Contains("Piza"));
            //Console.WriteLine(food.IndexOf("burger"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //food.Sort(); 
            //food.Reverse();
            //food.Clear();

            //Convert into array 
            //String[] foodArray = food.ToArray(); 

            //foreach (string item in food)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(food[0]);







            //Dictionary

            //Dictionary<int, string> rookieOfTheYear = new();

            //rookieOfTheYear.Add(2000, "Mike");
            //rookieOfTheYear.Add(2001, "Josh");
            //rookieOfTheYear.Add(2002, "John");
            //rookieOfTheYear.Add(2003, "mosh");

            //Console.WriteLine(rookieOfTheYear[2002]);

            //if (rookieOfTheYear.ContainsKey(2003))
            //{
            //    Console.WriteLine(rookieOfTheYear[2003]);
            //}




            //Dictionary<string, List<string>> wishlist = new Dictionary<string, List<string>>();

            //wishlist.Add("Tim Corey", new List<string> { "Xbox", "Tesla", "Pizza" });
            //wishlist.Add("Billy Bob", new List<string> { "PS5", "Ford", "Burger" });
            //wishlist.Add("Marry James", new List<string> { "Iphone 17", "mustang" });

            //// Use 'entry' instead of (key, value)
            //foreach (var entry in wishlist)
            //{
            //    Console.WriteLine(entry.Key + "'s wishlist is: ");
            //    foreach (var item in entry.Value)
            //    {
            //        Console.WriteLine("   - " + item);
            //    }
            //}

            //Console.WriteLine(wishlist["Tim Corey"][0]);








            //Hashsets
            // faster, no duplicates(same hash for duplicate element), 

            HashSet<string> hobbies = new HashSet<string>();
            hobbies.Add("Football");
            hobbies.Add("Golf");
            hobbies.Add("Cricket");
            hobbies.Add("Golf");
            hobbies.Add("Reading");

            //foreach (string hobby in hobbies)
            //{
            //    Console.WriteLine(hobby);
            //}

            //hobbies.Contains("Golf");


            HashSet<string> hobbiesA = new HashSet<string>();
            hobbiesA.Add("Writing");
            hobbiesA.Add("Football");

            HashSet<string> hobbiesB = new HashSet<string>();
            hobbiesB.Add("Golf");
            hobbiesB.Add("Football");

            //hobbiesA.UnionWith(hobbiesB);

            //var hobbiesU = hobbiesA.Union(hobbiesB).ToHashSet();

            //Console.WriteLine("Union of Hobbies:");
            //foreach (var item in hobbiesU)
            //{
            //    Console.WriteLine($" - {item}");
            //}

            //similar for intersection and other things


        }
    }
}
