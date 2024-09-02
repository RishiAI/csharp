using System.Collections.Generic;
using System.Reflection.PortableExecutable;

public class GD2_CH1to3
{
    public static (float, float) Totals(float[] costs)
    {
        float subtotal = 0;
        foreach (float i in costs)
        {
            subtotal += i;

        }
        float taxtotal = subtotal * 1.0825f;
        return (subtotal, taxtotal);
    }
    public static (string[], string[], float, float) EvaluateScores((string, int)[] students)
    {
        string[] names = new string[students.Length];
        for (int i = 0; i < students.Length; i++)
        {
            names[i] = students[i].Item1.ToString();
        }
        float passed = 0;
        float total = 0;
        List<string> meow = new List<string>();
        foreach ((string, float) x in students)
        {
            passed += x.Item2 >= 3 ? 1 : 0;
            total += x.Item2;
        }
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Item2 >= 3)
            {
                meow.Add(students[i].Item1);
            }

        }
        (string[], string[], float, float) ans = (names, meow.ToArray(), passed / students.Length, total / students.Length);
        return ans;
    }

    public static int Gather(char[] farm)
    {
        List<char> path = new List<char>();
        foreach (char c in farm) { path.Add(c); }
        int home = path.IndexOf('H');
        int steps = 0;
        int placeholder = 0;
        //leftsearch
        for (int i = home; i >= 0; i--)
        {
           
            if (path[i] == '-') { steps++; }
            if (path[i] == 'F')
            {
                steps += (home - i) * 2;
                path[i] = '-';
                i = home;
            }
            Console.WriteLine(i);
            Console.WriteLine(steps);
            Console.WriteLine(path[i]);
        }
        steps += home;
         
        //rightsearch
        for (int j = home; j < path.Count; j++)
            {
            if (path[j] == '-'){ steps++; }
                if (path[j] == 'F')
                {
                    steps += (j - home)*2;
                    path[j] = '-';
                    j = home;
                placeholder = j;
                }
            Console.WriteLine(j);
            Console.WriteLine(steps);
            Console.WriteLine(path[j]);
        }
            steps += placeholder - home;
            return steps;
        }
    }