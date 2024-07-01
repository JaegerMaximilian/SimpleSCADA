using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleSCADA_SharedResources;
using Microsoft.EntityFrameworkCore;

namespace SimpleSCADA_SharedResources
{
    public class Station
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Utility> Utilities { get; set; } = new();
        
        public ICollection<StationWithChosenUtility> ChosenUtilities { get; } = new List<StationWithChosenUtility>();

        #endregion

        #region Constructor
        // Default Constructor for EF-Core
        public Station()
        {
            //Recipes = new List<Recipe>();
        }
        public Station(string name, List<Utility> utilities)
        {
            this.Name = name;
            this.Utilities = utilities;
        }
        #endregion

        #region Methods

        #endregion

    }
}