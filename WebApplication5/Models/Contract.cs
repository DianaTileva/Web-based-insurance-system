using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Contract
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int InsuranceId { get; set; }

        public virtual User User { get; set; }
        public virtual Insurance Insurance { get; set; }

        public string Details { get; set; }
        public double FinalPrice { get; set; }
        public int Duration { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }
    }
}