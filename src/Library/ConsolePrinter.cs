using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter //Implementa la interfaz IPrinter

{
        public void PrintRecipe(IRecipe recipe) // Toma como parametro IRecipe
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}