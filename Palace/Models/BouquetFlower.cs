using System;
using System.Collections.Generic;

namespace Palace.Models;

public class BouquetFlower
{
  public int BouquetFlowerId { get; set; }
  public int BouquetId { get; set; }
  public Bouquet Bouquet {get; set; }
  public int FlowerId { get; set; }
  public Flower Flower { get; set; }
}