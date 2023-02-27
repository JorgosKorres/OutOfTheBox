using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class Gevangene
    {
        int id;
        string naam;
        int gevangeneType;
        bool vervroegdVrij;
        int opsluitTermijn;

        public Gevangene(int id, 
                         string naam, 
                         int gevangeneType, 
                         bool vervroegdVrij, 
                         int opsluitTermijn)
        {
            this.id = id;
            this.naam = naam;
            this.gevangeneType = gevangeneType;
            this.vervroegdVrij = vervroegdVrij;
            this.opsluitTermijn = opsluitTermijn;
        }
    }
}
