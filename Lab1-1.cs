using System;
using System.IO;

namespace ConsoleApp2
{

    class Tree
    {
        private int value;
        private Tree left;
        private Tree right;

       
        public void Insert(int value)
        {
            if (this.value == 0)
                this.value = value;
            else
            {
                if (this.value.CompareTo(value) > 0)
                {
                    if (left == null)
                        this.left = new Tree();
                    left.Insert(value);
                }
                else if (this.value.CompareTo(value) < 0)
                {
                    if (right == null)
                        this.right = new Tree();
                    right.Insert(value);
                }
                
            }
        }


        public string Print(Tree t)
        {
            string result = "";
            if (t.left != null)
                result += Print(t.left);

            result += t.value + "\n";

            if (t.right != null)
                result += Print(t.right);

            return result;
        }
    }   

        class Program
    {
        static void Main(string[] args)
        {
            StreamWriter f = new StreamWriter("test.txt", true);
            Tree t = new Tree();
            int[] arr = new int[] {72, 5, 78, 45, 34, 17, 9, 0, -2, -76 };

            for (int i=0; i<arr.Length; i++)
                t.Insert(arr[i]);

            f.WriteLine(t.Print(t));
            f.Close();
        }
    }
}
