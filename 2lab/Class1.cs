using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    internal class BUS
    {
        protected int kol = 0;
        protected double vart = 0;
        
        public BUS(int koll, double vartt) { 
        
            this.kol = koll;
            this.vart = vartt;

        }

        public virtual double zagvart()
        {
            return kol*vart;
        }
    }

    class Skoruy : BUS
    {

        double shv = 0;
        string marka = "";

        public Skoruy(int koll, double vartt, string markaa) : base(koll, vartt)
        {

            this.marka = markaa;

            if (markaa == "Nissan") shv = 70;
            else if (markaa == "Toyota") shv = 80;
            else if (markaa == "Ferrari") shv = 150;
        }

        public double GetShv()
        {
            return shv;
        }

        public override double zagvart()
        {
            return (vart + (0.05 * shv)) * kol;
        }

    }

}
