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
            "HotelAL.jpeg", "HotelAR.jpeg","HotelBR.jpg","HotelCH.jpg","HotelCO.jpg","HotelUSA.jpeg","HotelFR.jpeg","HotelIN.jpeg","HotelIT.jpeg","HotelME.jpg"
        };
        ListaAereos = new List<string>
        {
            "aereo.jpeg", "aereo.jpeg","aereo.jpeg","aereo.jpeg","aereo.jpeg","aereo.jpeg","aereo.jpeg","aereo.jpeg","aereo.jpeg","aereo.jpeg"
        };
        ListaExcursiones = new List<string>
        {
            "Alemania.jpg", "Argentina.jpg","Brasil.jfif","Chile.jpg","Colombia.jpg","Estados Unidos.webp","Francia.jpg","Inglaterra.jpg","Italia.jpg","Mexico.jpg"
        };
        Paquetes = new Dictionary<string, Paquete>();
    }
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if (ListaDestinos.Contains(destinoSeleccionado))
        {
            Paquetes.Add(destinoSeleccionado, paquete);
            return true;
        }
        else
        return false;
        
            
    }
}