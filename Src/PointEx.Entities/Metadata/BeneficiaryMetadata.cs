﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PointEx.Entities
{
    [MetadataType(typeof(BeneficiaryMetadata))]
    public partial class Beneficiary
    {
        public int Points
        {
            get
            {
                var purchases = this.Cards.SelectMany(c => c.Purchases).Sum(p => p.Amount);
                var exchanges = this.PointsExchanges.Sum(pe => pe.PointsUsed);
                return Convert.ToInt32(purchases - exchanges);
            }
        }
    }

    public class BeneficiaryMetadata
    {
        [DisplayName("Escuela")]
        [Required(ErrorMessage = null)]
        public int EducationalInstitutionId { get; set; }

        [DisplayName("Ciudad")]
        [Required(ErrorMessage = null)]
        public int TownId { get; set; }

        //[DisplayName("Fecha de Creación")]
        //public DateTime CreatedDate { get; set; }

        //[DisplayName("Fecha de Modificación")]
        //public DateTime? ModifiedDate { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = null)]
        public string Name { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [UIHint("Date")]
        public DateTime? BirthDate { get; set; }

        //[DisplayName("Dirección")]
        public string Address { get; set; }
    }
}
