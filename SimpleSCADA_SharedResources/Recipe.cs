using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleSCADA_SharedResources;
using Microsoft.EntityFrameworkCore;


namespace SimpleSCADA_SharedResources
{
    public class Recipe 
    {
        #region Properties
        public int Id { get; private set; }
        public string? Name { get; set; }
        public ICollection<StationWithChosenUtility> Stations { get; set; } = new List<StationWithChosenUtility>();
        public virtual ICollection<ProductionCycle> ProductionCycles { get; } = new List<ProductionCycle>(); // 1 to many with ProductionCycle

        #endregion

        #region Constructor
        // Default Constructor for EF-Core
        public Recipe()
        {

        }
        public Recipe(string name)
        {
            Name = name;
        }


        // Constructor only for Use in EditRecipe()
        public Recipe (int existingId, string name)
        {
            Id = existingId;
            Name = name;
        }
        #endregion

        #region Methods
        public void AddStation(StationWithChosenUtility station)
        {
            try
            {
                Stations.Add(station);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void RemoveStation(StationWithChosenUtility station)
        {
            Stations.Remove(station);
        }

        // BL: Hod do glaub i nix verloren?
        //public void Sort() //Sort by OrderNumber
        //{
            
        //}
        #endregion

    }
}

