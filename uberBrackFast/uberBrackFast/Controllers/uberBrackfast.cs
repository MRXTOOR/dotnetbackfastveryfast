using Microsoft.AspNetCore.Mvc;
namespace uberBrackFast.Controllers;
using uberBrackFast.Contracts.BrackFast;
using uberBrackFast.Models;
using uberBrackFast.Services.BrackFasts;

[ApiController]
[Route("[controller]")]
public class BrackFastController : ControllerBase
{
private readonly IBrackFastService _brackFastService;


[HttpPost]
public IActionResult CreateBrackfast(CreateBrackFastRequest request){
    var brackfast = new BrackFast(//Импорт из модели
        Guid.NewGuid(),
        request.Name,
        request.Description,
        request.StartDateTime,
        request.EndDateTime,
        DateTime.UtcNow,
        request.Sabory,
        request.Sweet //сопостовление данных с языком на котором говорит наше приложение 
    );
//сохранение вв базу данных
    var response = new BrackFastResponse(
        brackfast.Id,
        brackfast.Name,
        brackfast.Description,
        brackfast.StartDateTime,
        brackfast.EndDateTime,
        brackfast.LastModifiedDateTime,
        brackfast.Sabory,
        brackfast.Sweet //приеобразование в апи
    );

    return CreatedAtAction(
        actionName: nameof(GetBrackfast),
        routeValues: new {id = brackfast.Id},
        response);
}

[HttpGet("{id:guid}")]
public IActionResult GetBrackfast(Guid id){
    return Ok(id);
}

[HttpPut("{id:guid}")]
public IActionResult UpsertBrackfast(Guid id,UpsertBrackFastRequest request){
    return Ok(request);
}

[HttpDelete("{id:guid}")]
public IActionResult DeleteBrackfast(Guid id){
    return Ok(id);
}

}