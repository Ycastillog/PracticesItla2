using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentEasy.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }

        [Precision(18, 2)]
        public decimal RentAmount { get; set; }

        public bool IsAvailable { get; set; }
    }
}



