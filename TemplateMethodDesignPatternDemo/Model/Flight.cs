namespace TemplateMethodDesignPatternDemo.Model;

public record Flight(
    int FlightId, 
    string AircraftRegistrationNo,
    string Destination, 
    int NumberOfPassengers);
