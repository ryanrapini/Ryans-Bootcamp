namespace Backend
{
  public class Player
  {
    public int Id { get; private set; }
    public string? Name { get; set; }

    public bool IsEligible { get; set; }

    public string? Position { get; set; }

    public Player(int id, string name, string position = "")
    {
      Id = id;
      Name = name;
      Position = position;
    }

  }

}
