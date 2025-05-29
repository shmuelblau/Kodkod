public class FlightReservation
{
    public string PassengerName { get; private set; }
    public string From { get; private set; }
    public string To { get; private set; }
    public DateTime DepartureDate { get; private set; }
    public DateTime? ReturnDate { get; private set; }
    public bool IsBusinessClass { get; private set; }
    public string MealPreference { get; private set; }
    public string SeatPreference { get; private set; }

    private FlightReservation() { }

    public class Builder
    {
        private readonly FlightReservation reservation = new FlightReservation();

        public Builder(string passengerName, string from, string to, DateTime departureDate)
        {
            reservation.PassengerName = passengerName;
            reservation.From = from;
            reservation.To = to;
            reservation.DepartureDate = departureDate;
        }

        public Builder SetReturnDate(DateTime returnDate)
        {
            reservation.ReturnDate = returnDate;
            return this;
        }

        public Builder SetBusinessClass(bool isBusiness)
        {
            reservation.IsBusinessClass = isBusiness;
            return this;
        }

        public Builder SetMeal(string meal)
        {
            reservation.MealPreference = meal;
            return this;
        }

        public Builder SetSeat(string seat)
        {
            reservation.SeatPreference = seat;
            return this;
        }

        public FlightReservation Build()
        {
            return reservation;
        }
    }
}
