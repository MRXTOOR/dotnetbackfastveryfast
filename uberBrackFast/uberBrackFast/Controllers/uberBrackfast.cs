using Microsoft.AspNetCore.Mvc;
namespace uberBrackFast.Controllers;
using uberBrackFast.Contracts.BrackFast;
[ApiController]
public class BrackFastController : ControllerBase
{
[HttpPost("/brackfasts")]
public IActionResult CreateBrackfast(CreateBrackFastRequest request){
    return Ok(request);
}

[HttpGet("/brackfasts/{id:guid}")]
public IActionResult GetBrackfast(Guid id){
    return Ok(id);
}

[HttpPut("/brackfasts/{id:guid}")]
public IActionResult UpsertBrackfast(Guid id,UpsertBrackFastRequest request){
    return Ok(request);
}

[HttpDelete("/brackfasts/{id:guid}")]
public IActionResult DeleteBrackfast(Guid id){
    return Ok(id);
}

}