using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}