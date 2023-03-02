namespace OOPADVENTURE;

public static class Text //Static means there should only be one reference to this class throughout the entire system
{

    private static Language _language; //private to make sure there is only one reference to an instantiated language

    public static Language Language
    {
        get //Use a static getter to return an instance of the Language Class
        {
            if (_language == null)
            
                throw new Exception("No language loaded.");
            return _language;
            
        }
    }

    public static void LoadLanguage(Language language) //void makes "no return type"
    {
        _language = language;
    }

}