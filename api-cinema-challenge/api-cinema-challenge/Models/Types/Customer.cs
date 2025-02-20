﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Types;

[Table("customer")]
public class Customer
{
    [Column("id")]
    public int Id { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("phone")]
    public string Phone { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
