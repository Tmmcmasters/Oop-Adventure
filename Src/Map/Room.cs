namespace OOPADVENTURE;

public class Room
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        { Directions.North, -1 }, // -1 Let's us know that ther is no neighbor in that direction
        { Directions.South, -1 },
        { Directions.East, -1 },
        { Directions.West, -1 },
        { Directions.None, -1 },
    };
    
    public bool Visisted { get; set; } //Let's know that the room has been visited.

}
