using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public class DnaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string dna { get; set; }
        public bool isMutant { get; set; }
        public DateTime createdDateTime { get; set; }
    }
}
