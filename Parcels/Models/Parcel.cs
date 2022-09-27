using System.Collections.Generic; 

namespace Parcels.Models
{
  public class Parcel
  {

    public int Length { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public int Volume { get; set; }
    public int Weight { get; set; }
    //private static List<Parcel> _instances = new List<Parcel> {}; 

    public Parcel(int len, int width, int depth, int weight)
    {
      Length = len; //In Centimenters
      Width = width; //In Centimenters
      Depth = depth; //In Centimenters
      Volume = Len * Width * Depth;
      Weight = weight; 

      //_instances.Add(this); //Adds Parcel to '_instances'
    }

    public static List<Parcel> GetAll()  //'Getter' method
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static int Volume(){
      return Volume;
    }

  }
}
