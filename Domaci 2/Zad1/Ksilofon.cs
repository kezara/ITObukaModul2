﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable()]
    public class Ksilofon : UdarackiInstrument, IFunkcijaUOrkestru
    {
        public Ksilofon()
        {
            if (Program.illustrateFlag)
            {
                Console.WriteLine("Ksilofon kreiran");
            }
        }

        public override string ImeInstrumenta => "Ksilofon";
        public override bool OsnovaOdMetala => true;
        public override bool OsnovaOdPlastike => false;
        public override bool OsnovaOdDrveta => true;

        // Implementacija interfejsa IFunkcijaUOrkestru
        public string MojaFunkcijaUOrkestru { get; set; }
        public bool NeophodanSamZaSimfonijskiOrkestar => true;
        public string PripadamOrkestruPoImenu { get; set; }

        // Ispis osobina
        public override void Ispisi()
        {
            base.Ispisi();
            Console.WriteLine(
                "Moja funkcija u orkestru: " + MojaFunkcijaUOrkestru + "\n" +
                "Neophodan sam za simfonijski orkestar: " +
                ((NeophodanSamZaSimfonijskiOrkestar) ? "DA" : "NE") + "\n" +
                "Pripadam orkestru po imenu: " + PripadamOrkestruPoImenu);
        }

        public override void NastimujSe()
        {
            Console.WriteLine("{0} se stimuje...", ImeInstrumenta);
        }

        public override void Sviraj()
        {
            Console.WriteLine("{0} svira...", ImeInstrumenta);
        }
    }
}