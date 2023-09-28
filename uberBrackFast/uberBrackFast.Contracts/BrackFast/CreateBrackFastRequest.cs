namespace uberBrackFast.Contracts.BrackFast;

public record CreateBrackFastRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,

    DateTime EndDateTime,
    List<string> Sabory,
    List<string> Sweet
);