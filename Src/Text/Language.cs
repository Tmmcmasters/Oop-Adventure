namespace OOPADVENTURE;

public abstract class Language
{

    public string Welcome { get; protected set; } = ""; // protected set "protects" unwanted claasses from using this class
    public string ChooseYourName { get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    public string DefaultRoomName { get; protected set; } = "";
    public string DefaultRoomDescription { get; protected set; } = "";
}
