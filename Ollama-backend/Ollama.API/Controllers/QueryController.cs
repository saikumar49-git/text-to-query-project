using Microsoft.AspNetCore.Mvc;
using ollama.common.Models;
using ollama.Core.Interfaces;

namespace Ollama.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QueryController : ControllerBase
{
    private readonly IQueryService _queryService;
    private readonly ILogger<QueryController> _logger;

    public QueryController(IQueryService queryService, ILogger<QueryController> logger)
    {
        _queryService = queryService ?? throw new ArgumentNullException(nameof(queryService));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] QueryRequest request, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = await _queryService.ProcessNaturalLanguageQueryAsync(request, cancellationToken);

        if (!response.IsSuccess)
        {
            _logger.LogWarning("Query process failed: {Error}", response.Error);
            return BadRequest(response);
        }
            
        return Ok(response);
    }
}
