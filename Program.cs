using OOPADVENTURE;

Text.LoadLanguage(new English());

// language.ChooseYourName = "Hello, what is your name?" //This does not work because ChooseYOur name is actually set to private. We need to change either English or Language

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)
    name = Text.Language.DefaultName;

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);
//If you want to make different languages, you can just register them with a singleton, and all references to the singleton property will return a localized text