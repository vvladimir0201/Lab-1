using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            
            

            int[] dan = { 7, 60, 15, 44, 31 };

            int l = 1, k = 0;
            for (int j=0; j<= dan.Length; j++)
            {
                l += 2 * j;
            }


            string[] tree = new string[l];
            tree[0] = Convert.ToString(dan[0]);
            tree[1] = "f";
            tree[2] = "f";

            int  x, s;
            bool r = false;
            for (int i=1; i<dan.Length; i++)
            {

                s = 0;
                r = false;

                if (i == dan.Length - 1)
                {
                   

                }
                while (r == false)
                {
                    x = Convert.ToInt32(tree[s]);
                    if (dan[i]==x)
                        break;
                    if ((tree[s * 2 + 1] == "f") & (dan[i] < x))
                    {
                        tree[2 * s + 1] = Convert.ToString(dan[i]);
                        if (i != dan.Length - 1)
                        {
                            tree[(2 * s + 1) * 2 + 1] = "f";
                            tree[(2 * s + 1) * 2 + 2] = "f";
                        }
                        break;
                    }

                    if ((tree[s * 2 + 2] == "f") & (dan[i] > x))
                    {
                        tree[2 * s + 2] = Convert.ToString(dan[i]);
                        if (i != dan.Length - 1)
                        {
                            tree[(2 * s + 2) * 2 + 1] = "f";
                            tree[(2 * s + 2) * 2 + 2] = "f";
                        }
                        break;
                    }
                    if ((tree[s * 2 + 1] != "f") & (dan[i] < x))
                        s = s * 2 + 1;
                    if ((tree[s * 2 + 2] != "f") & (dan[i] > x))
                        s = s * 2 + 2;
                }
                
               
                    
            
            }

            




            StreamWriter n = new StreamWriter("test2.txt", true);

            for (int i=0; i<l; i++)
                if (tree[i] != "f")
                    n.WriteLine(tree[i]);





            n.Close();
        }
    }
}