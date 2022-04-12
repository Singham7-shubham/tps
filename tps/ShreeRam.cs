using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tps
{
  public class ShreeRam
    {
        public enum Lali
        {
        add,subtraCT,DIVIDE,multiply
        }
        private ShreeRam()
        {

        }
        public static void Main()
        {
            int[] a = new int[2];
            ShreeRam a1 = new ShreeRam();
            a1.lalu("jai",10,20,30,40,50,60,70);
            Console.WriteLine(Lali.DIVIDE.GetTypeCode()) ;
            Console.Read();
        }
        public void id()
        {

        }
    }
    public static class Hanuman
    {
        public static void lalu(this ShreeRam pr,string s,int a,params int []  d)
        {
            Console.WriteLine("Jai Shree Ram");
        }
    }
}
