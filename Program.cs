using System;

namespace ApredendoTecnicasHackingtank
{
    class Program
    {
        static string timeconservation(string s)
        {
            //var midday = s.Substring(s.Length - 2, 2);
            var time = s.Substring(0, s.Length - 2);
            var arr = time.Split(':');
            var hour = arr[0];
            var min = arr[1];
            var sec = arr[2];
            //if (midday.Equals("PM"))
           // {
                if (hour != "12")
                    hour = (int.Parse(hour) + 12).ToString();
            //}
            else
            {
                if (hour == "12")
                    hour = "00";
            }

            string format24 = hour + ":" + min + ":" + sec;
            return format24;
        }

        static void Main(string[] args)
        {

            var result = timeconservation("07:05:45PM"); 
            Console.WriteLine(result);
            // Console.WriteLine("Hello World!");
            // int soma = 0;
            // int va1 = 0, va2 = 0, va3 = 0, va4 = 0, va5 = 0, va6 = 0;
            //int[] a1 = new int[6];
            //a1[0] = int.Parse(Console.ReadLine());
            // a1[1] = int.Parse(Console.ReadLine());
            // a1[2] = int.Parse(Console.ReadLine());
            // a1[3] = int.Parse(Console.ReadLine());
            // a1[4] = int.Parse(Console.ReadLine());
            // a1[5] = int.Parse(Console.ReadLine());

            //  va1 = a1[0];
            // va2 = a1[1];
            // va3 = a1[2];
            // va4 = a1[3];
            // va5 = a1[4];
            // va6 = a1[5];

            // soma = va1 + va2 + va3  +va4 + va5 + va6;

            // Console.WriteLine(soma);
            // Console.ReadKey();


            /*
             * Complete the timeConversion function below.
             */


        }
   }
}