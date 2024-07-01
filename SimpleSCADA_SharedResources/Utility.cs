using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleSCADA_SharedResources;
using Microsoft.EntityFrameworkCore;


namespace SimpleSCADA_SharedResources
{
    public class Utility
    {
        #region Properties
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public List<Station> Stations { get; set; } = new();
        public ICollection<StationWithChosenUtility> ChosenUtilites { get; } = new List<StationWithChosenUtility>();
        public int SecondsToWait { get; set; }
        //public int  OrderNumber { get; set; }

        
        #endregion

        #region Constructor

        public Utility() { 
        }
        public Utility(string name, int secondsToWait)
        {
            this.SecondsToWait = secondsToWait;
            this.Name = name;
        }
        #endregion

        #region Methods

        #endregion

    }
}
