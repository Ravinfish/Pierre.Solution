using System;
using System.Collections.Generic;

namespace Palace.Models;

public class Flower
{
  public int FlowerId { get; set; }
  public string Type { get; set; }
  public string Description { get; set; }
  public string PhotoUrl { get; set; }
  public decimal Price { get; set; }
  public bool IsBouquet { get; set; }
  public List<BouquetFlower> BouquetFlowers { get; }
}