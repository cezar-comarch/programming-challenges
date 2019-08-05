using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace name_generator
{
    public static class Names {
        private static List<string> maleNamesList;
        private static List<string> femaleNamesList;
        private static Random r = new Random();

        static Names() => fillLists();

        private static void fillLists()
        {
            maleNamesList = null;
            femaleNamesList = null;

            try{
             maleNamesList = File.ReadAllLines("Data/maleNames.txt").ToList();
             femaleNamesList = File.ReadAllLines("Data/femaleNames.txt").ToList();
            }
            catch(FileNotFoundException ex) 
            {
                 Console.WriteLine(ex.ToString());
            }
            catch(DirectoryNotFoundException ex) 
            {
                 Console.WriteLine(ex.ToString());
            }
            catch(IOException ex) 
            {
                 Console.WriteLine(ex.ToString());
            }
        }

        public static string GetRandomMaleName() => maleNamesList[r.Next(maleNamesList.Count())];

        public static string GetRandomFemaleName() => femaleNamesList[r.Next(femaleNamesList.Count())];
        
        public static string GetRandomName() {
            var x = r.Next(2);
            if(x == 0) return GetRandomMaleName();
            else return GetRandomFemaleName();
        }
    }
}
