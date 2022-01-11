using CQRSTesting.Application.Services.TodoLists.CreateTodoList;
using CQRSTesting.Application.Services.TodoLists.GetAllTodoLists;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoListController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CreateTodoListResponse> CreateAsnyc(CreateTodoListRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
        public async Task<GetAllTodoListsResponse> GetAllAsnyc(GetAllTodoListsRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
