using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_SharedResources
{
    public class Plant
    {

        #region memberVars
        //Transitions _Transition;
        //int[] _sequence;

        #endregion memberVars

        #region Properties
        public int Id { get; private set; }
        public int? ActiveProductionCycleId { get; set; }
        public ProductionCycle? ActiveProductionCycle { get; set; } = null!;
        public PlantState ActualPlantState { get; set; }
        public PlantState requestedPlantState { get; set; }

        //private DbSet<StatusPlantInformation> StatusPlantStates;
        
        #endregion

        #region Constructor

        public Plant() // needed for Kenan
        {
           // _Transition = new Transitions();
           //for (int i = 0; i < StatusPlants.Count(); i++)
           //{
           //    StatusPlants.SingleOrDefault(x => x.Id == i);
           //}
           
           //FL: Auskommentiert da kommt eine NullReferenceException
           //StatusPlants.Add(new StatusPlantInformation());
        }
        
        #endregion

       

        #region Methods

        #endregion
    }
}
