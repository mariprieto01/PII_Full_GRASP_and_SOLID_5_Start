using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent) //recibe un objeto de tipo IRecipeContent
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}