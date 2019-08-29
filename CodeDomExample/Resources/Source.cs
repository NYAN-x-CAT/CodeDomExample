
using System;
using System.Windows.Forms;

namespace Example
{
    public class Program
    {
        public static string name = "#name";
        public static string country = "#country";

        public static void Main()
        {
            MessageBox.Show("My name is: " + name);
            MessageBox.Show("I'm from: " + country);
        }
    }
}