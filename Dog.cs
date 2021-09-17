namespace Basics
{
  public class Dog
  {
    private int _health;
    public string Name;
    public int Age { get; set; }
    public int Health { get { return _health; } }
    public void Play(PlayType playType, int minutes = 30)
    {
      if (minutes < 10) return;

      switch (playType)
      {
        case PlayType.Run:
          _health += (10 * minutes);
          break;
        case PlayType.Jump:
          _health += (5 * minutes);
          break;
      }
    }

    public Dog(string name = "molly")
    {
      Name = name;
      _health = 100;
    }
  }
}
