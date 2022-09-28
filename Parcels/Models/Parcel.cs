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

    public Parcel(string len, string beam, string hgt, string wgt)
    {
      Length = 
      if(int.TryParse(len, out int length); //In Centimenters
      Width = int.TryParse(beam, out int width); //In Centimenters
      Depth = int.TryParse(hgt, out int depth); //In Centimenters
      Volume = Length * Width * Depth;
      Weight = int.TryParse(wgt, out int weight); 

      //_instances.Add(this); //Adds Parcel to '_instances'
    }

    /*
    public static List<Parcel> GetAll()  //'Getter' method
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    */ 

    //No 'Volume()' function because we can just use the property instead. 

    public string CostToShip()
    {
      int cost = (2*Volume) + (3*Weight);
      string retval = cost.ToString();
      return retval; 
    }

  }
}
