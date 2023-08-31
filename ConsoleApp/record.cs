/*
 public record Location
{
    public string Address { get; init; }
    public string Province { get; init; }
}
public class nepal
{
    public string Address { get; init; }
    public string Province { get; init; }

}
*/
public record Manufacture(int id, string name, Country country);

public record Vehicle(Manufacture manufacture,string model);


public enum Country
{
    Germany=1,
    Itali=2,
    France =3,
    China =4,   
    UnitedKingdom=5
}
