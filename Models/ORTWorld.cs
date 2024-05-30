public class ORTWorld
{

    public static List<string> ListaDestinos { get; private set; }
    public static List<string> ListaHoteles { get; private set; }
    public static List<string> ListaAereos { get; private set; }
    public static List<string> ListaExcursiones { get; private set; }
    public static Dictionary<string, Paquete> Paquetes { get; private set; }

    static ORTWorld()
    {
        ListaDestinos = new List<string>
        {
            "Brasil", "Chile", "Colombia", "Italia", "Francia", "Inglaterra", "Estados Unidos", "Alemania", "Mexico", "Argentina"
        };
        ListaHoteles = new List<string>
        {
            "Alemania.jpg", "Argentina.jpg","Brasil.jfif","Chile.jpg","Colombia.jpg","Estados Unidos.webp","Francia.jpg","Inglaterra.jpg","Italia.jpg","Mexico.jpg"
        };
        ListaAereos = new List<string>
        {
            "Alemania.jpg", "Argentina.jpg","Brasil.jfif","Chile.jpg","Colombia.jpg","Estados Unidos.webp","Francia.jpg","Inglaterra.jpg","Italia.jpg","Mexico.jpg"
        };
        ListaExcursiones = new List<string>
        {
            "Alemania.jpg", "Argentina.jpg","Brasil.jfif","Chile.jpg","Colombia.jpg","Estados Unidos.webp","Francia.jpg","Inglaterra.jpg","Italia.jpg","Mexico.jpg"
        };
        Paquetes = new Dictionary<string, Paquete>();
    }
    static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if (Paquetes.ContainsKey(destinoSeleccionado))
            return false;
        else
            return true;
    }
}