

var reservation = new FlightReservation1(
    "David Levi",
    "TLV",
    "JFK",
    new DateTime(2025, 7, 15),
    null,
    true,
    "Vegetarian",
    "Window"
);



//-------------------------------------------------------------------------------------------------

















var reservation1 = new FlightReservation.Builder("David Levi", "TLV", "JFK", new DateTime(2025, 7, 15))
                    .SetBusinessClass(true)
                    .SetMeal("Vegetarian")
                    .SetSeat("Window")
                    .Build();

