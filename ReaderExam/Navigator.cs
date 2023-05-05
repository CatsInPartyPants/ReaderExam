using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderExam
{
    internal class Navigator
    {
        string[] allWords;
       string[] allPages;
        public int currentPage;
        public int totalPages;

        public Navigator(string text)
        {
            currentPage = 0;
            totalPages = 0;
            
            allWords = text.Split(' ');
            int size = allWords.Length;
            
            if(size > 100)
            {
                allPages = new string[size];
                for (int i = 0, j = 0; i < size; i++)
                {
                    if (i % 100 == 0 && i != 0)
                    {
                        j++;
                        totalPages++;
                        allPages[j] = allWords[i] + " ";
                    }
                    else
                    {
                        allPages[j] += allWords[i] + " ";
                    }

                }
            }
            else
            {
                allPages = new string[1];
                for (int i = 0; i < size; i++)
                    allPages[0] = allWords[i] + " ";
            }
            
        }

        public string ShowPage(int n)
        {
            if(n < 0 || n == 0)
            {
                n = 0;
            }
            else if( n > totalPages)
            {
                n = totalPages;
            } 
            return allPages[n];
        }

    }
}
