using InstrumentLibrary.Models;
using System;

namespace InstrumentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Guitar myGuitar = new Guitar("Gibson");
            Mandolin myMandolin = new Mandolin("Kentucky KM-140");
            Ukulele myUkulele = new Ukulele("Ortega");

            myUkulele.SerialNumber = "abc123";

            myGuitar.Play();
            myMandolin.Play();
            myUkulele.Play();
        }
    }
}
