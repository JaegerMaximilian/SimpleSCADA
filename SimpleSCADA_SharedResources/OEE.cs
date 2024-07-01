using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSCADA_SharedResources
{
    public class OEE
    {
        #region Properties
        public int Id { get; private set; } // brauchen wir ID zwingend? weil nicht in Klassendiagramm
        public DateTime Date { get; private set; }
        public double Availability { get;  set; } //private set, oder von außen zugreifbar?
        public double QualityRate { get; private set; } //private set, oder von außen zugreifbar?
        public double Leistungseffizienz { get; private set; }
        #endregion

        #region Constructor
        //Frage zum Konstruktor: was braucht der OEE alles schon zum initialiseren als Inputs beim Konstruktor,
        // sind id und date genug?
        public OEE(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
        #endregion

        #region Methods
        public double CalculateOEE() 
        {
            return 0;
        }
        #endregion


    }
}
