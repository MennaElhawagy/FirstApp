using System;
using System.Collections.Generic;

namespace FirstApp.Models;

public partial class TypeOfCar
{
    public int Id { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public string? Vin { get; set; }

    public string? LicensePlateNumber { get; set; }

    public int? Year { get; set; }

    public virtual ICollection<CarRental> CarRentals { get; set; } = new List<CarRental>();
}
