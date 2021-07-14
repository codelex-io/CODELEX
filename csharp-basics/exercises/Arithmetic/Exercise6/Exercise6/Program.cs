using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void CozaLozaWoza()
        {
            int lowerBound = 1;
            int upperBound = 110;
            int numbersPerLine = 11;
            int lines = upperBound / numbersPerLine;

            for(int i = 0; i < lines; i++)
            {
                List<string> lineList = new List<string>();

                for(int j = lowerBound; j <= upperBound; j++)
                {
                    if(j % 3 == 0 && j % 5 == 0)
                    {
                        lineList.Add("CozaLoza");
                    } 
                    else if(j % 3 == 0)
                    {
                        lineList.Add("Coza");
                    } 
                    else if(j % 5 == 0)
                    {
                        lineList.Add("Loza");
                    } 
                    else if(j % 7 == 0)
                    {
                        lineList.Add("Woza");
                    } 
                    else
                    {
                        lineList.Add(j.ToString());
                    }
                    lowerBound++;

                    if(j % numbersPerLine == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{lineList[0]} {lineList[1]} {lineList[2]} {lineList[3]} {lineList[4]} {lineList[5]} {lineList[6]} {lineList[7]} {lineList[8]} {lineList[9]} {lineList[10]} ");
            }
        }

        static void Main(string[] args)
        {
            CozaLozaWoza();
            Console.ReadKey();
        }
    }
}
