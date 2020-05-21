using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Music
  {
    public string Description { get; set; }
    public int Id {get; }
    private static List<Music> _instances = new List<Music> {};

      public Music (string description)
      {
        Description = description;
        _instances.Add(this);
        Id = _instances.Count;
      }

      public static List<Music> GetAll()
      {
        return _instances;
      }
      
      public static void ClearAll()
      {
        _instances.Clear();
      }

      public static Music Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}