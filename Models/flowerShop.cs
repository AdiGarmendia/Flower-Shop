using System.Collections.Generic;

namespace flower_shop {
  public class flowerShop {
    public List<Rose> Roses = new List<Rose> ();
    public List<Lily> Lilys = new List<Lily> ();
    public List<Poppy> Poppys = new List<Poppy> ();
    public List<Tulip> Tulips = new List<Tulip> ();

    public List<IMothersDay> MakeMothersDayArrangement () {
      List<IMothersDay> Arrangement = new List<IMothersDay> ();
      Arrangement.Add (new Tulip ());
      Arrangement.Add (new Tulip ());
      Arrangement.Add (new Poppy ());
      Arrangement.Add (new Poppy ());
      Arrangement.Add (new Poppy ());

      return Arrangement;

    }

    public List<IBirthday> MakeBirthdayArrangement () {
      List<IBirthday> Arrangement = new List<IBirthday> ();
      Arrangement.Add (new Lily ());
      Arrangement.Add (new Lily ());
      Arrangement.Add (new Rose ());
      Arrangement.Add (new Rose ());
      Arrangement.Add (new Rose ());

      return Arrangement;

    }

    public List<IGetWell> MakeGetwellArrangement () {
      List<IGetWell> Arrangement = new List<IGetWell> ();
      Arrangement.Add (new Mildew ());
      Arrangement.Add (new Mildew ());
      Arrangement.Add (new Mildew ());

      return Arrangement;

    }
  }
}