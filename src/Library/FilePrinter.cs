using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter //Implementa la interfaz IPrinter
    {
        public void PrintRecipe(IRecipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}