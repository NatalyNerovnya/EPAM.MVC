using ModelValidation.Infrastructure;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
    [VoucherValidation]
    public class Voucher
    {
        [Required]
        [Remote("ValidateName", "Home")]
        public string Name { get; set; }

        [PrefixLogic(3)]
        public string Prefix { get; set; }

        public string Postfix { get; set; }

        [DisplayName("Min Amount")]
        public decimal? MinimalAmount { get; set; }

        public decimal? Percentage { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public bool SingleUse { get; set; }

        public string Title
        {
            get
            {
                return string.Format("Voucher {0}",
                    string.Format("{0} {1} {2}", Prefix, Name, Postfix)
                    .Trim().Replace(' ', '_'));
            }
        }
    }
}