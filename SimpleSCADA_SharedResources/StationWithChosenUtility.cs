using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SimpleSCADA_SharedResources
{
    public class StationWithChosenUtility
    {
        #region Properties
        public int Id { get; private set; }
        public int OrderNumber { get;set; }
        public int StationId { get; set; }
        public Station Station { get; set; } = null!;

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        public int ChosenUtilityId{ get; set; }
        public Utility ChosenUtility { get; set; } = null!;


        #endregion

        #region Constructor
        public StationWithChosenUtility()
        {
       
        }

        public StationWithChosenUtility(Recipe recipe,Station station, Utility chosenUtility)
        {
            Recipe = recipe;
            Station = station;
            ChosenUtility = chosenUtility;
        }
        public StationWithChosenUtility(Recipe recipe, Station station, Utility chosenUtility, int orderNumber)
        {
            Recipe = recipe;
            Station = station;
            ChosenUtility = chosenUtility;
            OrderNumber = orderNumber;
        }
        #endregion

        #region Methods

        #endregion
    }
    

}
