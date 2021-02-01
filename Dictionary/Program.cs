using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> adYas = new MyDictionary<string, int>();
            adYas.Add("Eray", 20);
            adYas.Add("Emir", 19);
            adYas.Add("Yiğit", 18);


            Console.WriteLine(adYas.Count);

        }








}
    
}
