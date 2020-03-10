using System;

namespace flower_shop {
  public class Rose : IBirthday {
    public string Color { get; set; }
    public string Name { get; set; }

    public int PetalCount { get; set; }

    public string Species { get; set; }

    public bool Thorny { get; set; }

    public override string ToString () {
      return $"A fanciful {Color} rose with {PetalCount} petals.";
    }
  }
}