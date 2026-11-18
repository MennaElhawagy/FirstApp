using System;
using System.Collections.Generic;

namespace FirstApp.Models;

public partial class CarRental
{
    public int Id { get; set; }

    public string? Customer { get; set; }

    public DateTime? DateRented { get; set; }

    public DateTime? DateReturned { get; set; }

    public decimal? Cost { get; set; }

    public int? TypeOfCarId { get; set; }

    public virtual TypeOfCar? TypeOfCar { get; set; }
}
