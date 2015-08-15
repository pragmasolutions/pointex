﻿using System.ComponentModel.DataAnnotations;

namespace PointEx.Entities.Enums
{
    public enum BenefitStatusEnum
    {
        [Display(Name = "Pendiente")]
        Pending = 1,
        [Display(Name = "Aprobado")]
        Approved = 2,
        [Display(Name = "Rechazado")]
        Rejected = 3
    }
}
