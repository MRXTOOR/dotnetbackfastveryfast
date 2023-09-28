namespace uberBrackFast.Contracts.BrackFast;

public record UpsertBrackFastRequest
(
    string Name,
    string Description,
    DateTime StartDateTime,

    DateTime EndDateTime,
    List<string> Sabory,
    List<string> Sweet
);