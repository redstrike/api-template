namespace Namespace.Resource.Commands.Post;

public class Command : IRequest<SingleResponse<Response>>
{
      [FromBody] public DTO DTO { get; set; }  
}



