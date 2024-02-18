using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Palace.ViewModels
{
    public class SingleFlower
    {
        [Required(ErrorMessage = "Please select a flower.")]
        public int FlowerId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        public IEnumerable<SelectListItem> FlowerOptions { get; set; }

        public string Description { get; set; }
        public decimal IndividualCost { get; set; }
    }
}