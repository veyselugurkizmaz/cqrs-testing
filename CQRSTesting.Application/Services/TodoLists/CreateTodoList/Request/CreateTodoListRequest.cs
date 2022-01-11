using MediatR;

namespace CQRSTesting.Application.Services.TodoLists.CreateTodoList
{
    public record CreateTodoListRequest : IRequest<CreateTodoListResponse>
    {
        public string Name { get; set; }
    }
}
