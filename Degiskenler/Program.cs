using System;

namespace Degiskenler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b=5;
            sbyte c=5;

            short s=5;
            ushort u=5;

            Int16 i16=5;
            int i=5;
            Int32 i32=5;
            Int64 i64=5;

            float f=5;
            double d=5;
            decimal de=5;

            char c1='2';
            string str ="M.A. Gurbuzer";

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1="x";
            object o2="y";
            object o3=3;
            object o4 = 4.4;

            string str1="alper";
            string str2="a2";

            string birlestir=str1+" "+str2;

            int integer1=1;
            int integer2=1;

            int sum=integer1+integer2;

            bool b1=true;
            bool b2=10<2;

            string str20="20";
            int int20=20;
            int newValue=int20+ Convert.ToInt32(str20);
            Console.WriteLine(newValue);


            Console.ReadKey();




        }
    }
}