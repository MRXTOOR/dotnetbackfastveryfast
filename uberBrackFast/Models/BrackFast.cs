namespace uberBrackFast.Models;

public class BrackFast
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public DateTime LastModifiedDateTime { get; set; }
    public List<string> Sabory { get; set; }
    public List<string> Sweet { get; set; }

public BrackFast(
    Guid id,
    string name,
    string description,
    DateTime startDateTime,
    DateTime endDateTime,
    DateTime lastModifiedDateTime,
    List<string> sabory,
    List<string> sweet
    )
{
    Id = id;
    Name = name;
    Description = description;
    StartDateTime = startDateTime;
    EndDateTime = endDateTime;
    LastModifiedDateTime = lastModifiedDateTime;
    Sabory = sabory;
    Sweet = sweet;
}

}