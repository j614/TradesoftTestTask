
using System.ComponentModel.DataAnnotations.Schema;

namespace TradesoftTestTask
{
   public class Analog
    {
        public int id { get; set; }

        [Column("Артикул 1")]
        public string articleOne { get; set; }

        [Column("Производитель 1")]
        public string manufacturerOne { get; set; }

        [Column("Артикул 2")]
        public string articleTwo { get; set; }
        [Column("Производитель 2")]
        public string manufacturerTwo { get; set; }

        [Column("Доверие")]
        public int confidence { get; set; }
    }
}
