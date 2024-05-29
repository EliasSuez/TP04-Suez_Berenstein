public class ORTWorld
{

    public static List<string> ListaDestinos { get; private set; }
    public static List<string> ListaHoteles { get; private set; }
    public static List<string> ListaAereos { get; private set; }
    public static List<string> ListaExcursiones { get; private set; }
    public static Dictionary<string, Paquete> Paquetes { get; private set; }

    public ORTWorld(List<string> listadestinos, List<string> listahoteles, List<string> listaaereos, List<string> listaexcursiones, Dictionary<string, Paquete> paquetes)
    {
        ListaDestinos = listadestinos;
        PrecargarDestinos(ListaDestinos);
        ListaHoteles = listahoteles;
        ListaAereos = listaaereos;
        ListaExcursiones = listaexcursiones;
        Paquetes = paquetes;
    }

    private static void PrecargarDestinos(List<string> ListaDestinos)
    {
        ListaDestinos.Add("Brasil");
        ListaDestinos.Add("Chile");
        ListaDestinos.Add("Colombia");
        ListaDestinos.Add("Italia");
        ListaDestinos.Add("Francia");
        ListaDestinos.Add("Inglaterra");
        ListaDestinos.Add("Estados Unidos");
        ListaDestinos.Add("Alemania");
        ListaDestinos.Add("Mexico");
        ListaDestinos.Add("Argentina");
    }

    private static void PrecargarHoteles(List<string> ListaHoteles)
    {
        ListaHoteles.Add();
    }

    static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if (Paquetes.ContainsKey(destinoSeleccionado))
            return false;
        else
            return true;
    }

}