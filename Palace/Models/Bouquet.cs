using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Palace.Models;

public class Bouquet
{
  public int BouquetId { get; set; }
  [Required]
  public string Name { get; set; }
  [Required]
  public string Size { get; set; }
  public decimal Price { get; set; }
  public List<BouquetFlower> BouquetFlowers { get; }
}