
using System;
using System.Windows.Forms;

namespace Example
{
    public class Program
    {
        public static string MyName = "#name"; // will replace #name to whatever name the user enter in the builder
        public static string MyCountry = "#country";

        public static void Main()
        {
            MessageBox.Show("I'm : " + MyName);
            MessageBox.Show("I'm from: " + MyCountry);
        }
    }
}