using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentLibrary.Models
{
    public abstract class Instrument
    {
        public string SerialNumber { get; set; }

        public string Name { get; set; }

        public Instrument(string _name)
        {
            Name = _name;
        }

        public abstract void Play();
    }
    
    public class Guitar : Instrument
    {
        public Guitar(string _name) : base(_name)
        {

        }

        public override void Play()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"I am player a {Name} Guitar");
        }
    }
    public class Mandolin : Instrument
    {
        public Mandolin(string _name) : base(_name)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"I am player a {Name} Mandolin");
        }
    }
    public class Ukulele : Instrument
    {
        public Ukulele(string _name) : base(_name)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"I am player a {Name} Ukulele");
        }
    }
}
