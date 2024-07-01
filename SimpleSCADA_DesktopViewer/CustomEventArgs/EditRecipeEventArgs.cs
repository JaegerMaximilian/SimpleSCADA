using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.CustomEventArgs
{
    public class EditRecipeEventArgs:EventArgs
    {
        public string RecipeName;
        public Recipe EdittedRecipe;

        public EditRecipeEventArgs(string recipeName, Recipe edittedRecipe)
        {
            this.RecipeName = recipeName;
            this.RecipeName = recipeName;
        }

    }
}
