using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderExam
{
    internal class Navigator
    {
        string[] allStrings;
        string[] allPages;
        public int currentPage;
        public int totalPages;


        public Navigator(string text)
        {

            currentPage = 0;
            allStrings = text.Split(" ");
            int size = allStrings.Length;
            if(size >= 100)
            {
                allPages = new string[size];
                for (int i = 0, j = -1; i < size; i++)
                {
                    if (i % 40 == 0)
                    {
                        j++;
                    }
                    else
                    {
                        allPages[j] += allStrings[i] + " ";
                    }
                }
            }
            else
            {
                allPages = new string[1];
                for (int i = 0; i < size; i++)
                    allPages[0] += allStrings[i];
            }
            totalPages = allPages.Length;
        }

        public string ShowPage(int n)
        {
            return allPages[n];
        }

    }
}
