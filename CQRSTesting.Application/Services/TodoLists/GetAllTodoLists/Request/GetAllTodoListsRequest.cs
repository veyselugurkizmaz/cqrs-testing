using MediatR;

namespace CQRSTesting.Application.Services.TodoLists.GetAllTodoLists
{
    public record GetAllTodoListsRequest : IRequest<GetAllTodoListsResponse>
    {
        public static GetAllTodoListsRequest Create()
        {
            return new GetAllTodoListsRequest();
        }
    }
}
