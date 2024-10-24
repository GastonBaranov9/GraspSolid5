namespace Full_GRASP_And_SOLID;

public interface IRecipe //Interfaz publica que debe de cumplirse estrictamente
{
    string GetTextToPrint(); //Metodo que sera implementado para mostrar por ejemplo una receta
    public Product FinalProduct { get; set; } //Define producto final de la receta la cual todas deben de tener
    public void AddStep(Product input, double quantity, Equipment equipment, int time); //Agrega un paso a la receta es obligatorio
    public void AddStep(string description, int time);  
}