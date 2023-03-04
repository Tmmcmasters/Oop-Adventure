namespace OOPADVENTURE;


//This is all the logic that will allow us to create a single actions instance that we can use anywhere inside of our game. 
public sealed class Actions
{
    private static Actions _instance;

    public static Actions Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Actions();

            return _instance;
        }
    }

    private readonly Dictionary<string, Action> _registeredActions = new();

    private Actions ()
    {

    }
}