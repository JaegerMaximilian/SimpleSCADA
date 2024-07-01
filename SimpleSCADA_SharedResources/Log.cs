using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SimpleSCADA_SharedResources
{
    public class Log
    {
        #region Properties
        public int Id { get;private set; }
        public int? ProductionCycleId { get; set; } // 1 to many with ProductionCycle
        public ProductionCycle? ProductionCycle { get; set; } = null!;  // 1 to many with ProductionCycle
        public Error? Error { get; set; } // 1 to 1 with Error
        public string Description { get; private set; }
        public DateTime Starttime { get; private set; }
        public PlantState PlantState { get; private set; }
        #endregion

        #region Constructor
        public Log( string description, DateTime starttime, PlantState plantState) // Constructor for ErrorManager
        {
            
            
            Description = description;
            Starttime = starttime;
            PlantState = plantState;
        }

        public Log(int productionCycleId, string description, DateTime starttime, PlantState plantState) // Constructor for PlantManager
        {

            ProductionCycleId = productionCycleId;
            Description = description;
            Starttime = starttime;
            PlantState = plantState;
        }

        #endregion

        #region Methods

        #endregion

    }
}
