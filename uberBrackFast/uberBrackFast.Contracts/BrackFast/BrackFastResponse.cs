namespace uberBrackFast.Contracts.BrackFast;

public record BrackFastResponse
(   
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime LastModifiedDateTime,
    DateTime EndDateTime,
    List<string> Sabory,
    List<string> Sweet
);