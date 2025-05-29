public class FlightReservation1
{
    public string PassengerName { get; }
    public string From { get; }
    public string To { get; }
    public DateTime DepartureDate { get; }
    public DateTime? ReturnDate { get; }
    public bool IsBusinessClass { get; }
    public string MealPreference { get; }
    public string SeatPreference { get; }

    public FlightReservation1(
        string passengerName,
        string from,
        string to,
        DateTime departureDate,
        DateTime? returnDate,
        bool isBusinessClass,
        string mealPreference,
        string seatPreference)
    {
        PassengerName = passengerName;
        From = from;
        To = to;
        DepartureDate = departureDate;
        ReturnDate = returnDate;
        IsBusinessClass = isBusinessClass;
        MealPreference = mealPreference;
        SeatPreference = seatPreference;
    }
}
