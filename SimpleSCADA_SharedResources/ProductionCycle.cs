using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SimpleSCADA_SharedResources
{
    public class ProductionCycle
    {
        #region Properties
        public int Id { get; private set; } // string oder int???
        public int RecipeId { get; set; }// 1 to many with recipe 
        public Recipe Recipe { get; set; } = null!; // 1 to many with recipe
        public virtual ICollection<Log> Logs { get; set; } = new List<Log>(); // 1 to many with Logs
        public Plant? Plant { get; set; } // 1 to 1 with Plant

        public string Customer { get;  set; }
        public int NumberOfProducts { get;  set; }
        public int FinishedProducts { get; set; }
        public double EstimatedTime { get;  set; } //ist das nicht überflüssig weil ein Vielfaches von EstimatedDuration in Recipe.cs?
        #endregion

        #region Constructor
        //public ProductionCycle(string customer, int numberOfProducts)
        //{
        //    Customer = customer;
        //    //Recipe = recipe;
        //    NumberOfProducts = numberOfProducts;
        //    FinishedProducts = 0;
        //    //EstimatedTime = calculated from recipe and numberOfProducts, right?
        //}

        public ProductionCycle (string customer, int numberOfProducts) // constructor for kenan
        {
            Customer = customer;
            NumberOfProducts = numberOfProducts;
        }
        // Für Datenbank
        public ProductionCycle(string customer, int recipeId, int numberOfProducts)
        {
            Customer = customer;
            //Recipe = recipe;
            NumberOfProducts = numberOfProducts;
            FinishedProducts = 0;
            RecipeId = recipeId;
            //EstimatedTime = calculated from recipe and numberOfProducts, right?
        }
        // Nur für die View
        public ProductionCycle(string customer, Recipe recipe, int numberOfProducts)
        {
            Customer = customer;
            Recipe = recipe;
            NumberOfProducts = numberOfProducts;
            FinishedProducts = 0;
            //EstimatedTime = calculated from recipe and numberOfProducts, right?
        }
        // Nur für die View
        public ProductionCycle(int existingId, string customer, int recipeId, int numberOfProducts)
        {
            Id = existingId;
            Customer = customer;
            //Recipe = recipe;
            NumberOfProducts = numberOfProducts;
            FinishedProducts = 0;
            RecipeId = recipeId;
            //EstimatedTime = calculated from recipe and numberOfProducts, right?
        }
        // Nur für die View
        public ProductionCycle(int existingId, string customer, Recipe recipe, int numberOfProducts)
        {
            Id = existingId;
            Customer = customer;
            Recipe = recipe;
            NumberOfProducts = numberOfProducts;
            FinishedProducts = 0;
            //EstimatedTime = calculated from recipe and numberOfProducts, right?
        } 

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Auftragname:{this.Id} - {this.Customer}" + Environment.NewLine + $"Rezept:{this.Recipe.Id} - {this.Recipe.Name}" + Environment.NewLine + 
                $"Stückzahl gesamt: {this.NumberOfProducts}" + Environment.NewLine + "Status: in Queue";
        }

        #endregion

    }
}
