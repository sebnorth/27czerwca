﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class Konto
    {
        private string wlasciciel;

        public string Wlasciciel
        {
            get { return wlasciciel; }
            set { wlasciciel = value; }
        }

        private int saldo;

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Konto(string wlasciciel, int saldo)
        {
            this.wlasciciel = wlasciciel;
            this.saldo = saldo;
        }

        public override string ToString()
        {
            return $"Konto: wlasciciel: {this.wlasciciel}, saldo: {this.saldo}";
        }

        public virtual void Wyplata(int wyplata) {
            this.saldo -= wyplata;
        }
    }
}
