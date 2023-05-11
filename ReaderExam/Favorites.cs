using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderExam
{
    abstract class Favorites
    {
        public static void AddToFile(string text)
        {
            using(StreamWriter sw = new StreamWriter("Favorites.txt", true, System.Text.Encoding.Default))
            {
                sw.Write(text + "\n\n\n");
                sw.Flush();
                sw.Close();
            }
        }
    }
}
