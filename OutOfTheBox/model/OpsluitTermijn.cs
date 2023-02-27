using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class OpsluitTermijn
    {
        int id;
        DateTime opsluitDatum;
        double opsluitTermijn;
        bool levenslang;
        DateTime? datumVrijlating;

        public OpsluitTermijn(int id, 
                              DateTime opsluitDatum, 
                              double opsluitTermijn, 
                              bool levenslang=false, 
                              DateTime? datumVrijlating=null)
        {
            this.id = id;
            this.opsluitTermijn = opsluitTermijn;
            this.levenslang = levenslang;
            this.datumVrijlating = datumVrijlating;
        }
    }
}
