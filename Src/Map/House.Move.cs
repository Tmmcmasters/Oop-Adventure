namespace OOPADVENTURE;

public partial class House
{
    public Room CurrentRoom { get; set; } //Represents the current room the player is in so we can access it anywhere in our game. 
    public void GoToRoom (int index)
    {
        if (CurrentRoom != null)
            CurrentRoom.Visisted = true;

        CurrentRoom = Rooms[index];
    }
    public void GoToStartingRoom()
    {
        GoToRoom(_rnd.Next(0, Rooms.Length));
    }
}