using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static List<string> Map = new List<string>();
    
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        GetMap(W,H);
        // Récupération des lettres ou symbole existant
        var lettres = Map[0].Replace(" ", String.Empty);
        foreach(var l in lettres)
        { 
            var position = Map[0].IndexOf(l);
            Console.WriteLine(l.ToString()  + GetIndex(position, H, W).ToString());
        }
    }
    // initialise la carte du jeu
    static void GetMap(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
            Map.Add(line);
        }
    }
    // Récupère index de fin suivant les regles du jeu
    static char GetIndex(int pos, int height, int width)
    {
        for (int i = 1; i < height; i++)
        {
            string line = Map[i];
            var rightChar = (pos < width-1)?  line[pos+1] : ' ';
            var leftChar = (pos > 0)?  line[pos-1] : ' ';
            
            if(leftChar.Equals('-'))
            {
                pos -= 3;
            }
            
            if(rightChar.Equals('-'))
            {
                pos += 3;
            }
        }
        return Map[height-1][pos];
    }
}
