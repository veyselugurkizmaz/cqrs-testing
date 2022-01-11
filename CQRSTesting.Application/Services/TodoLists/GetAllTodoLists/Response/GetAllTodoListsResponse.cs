using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CQRSTesting.Application.Services.TodoLists.GetAllTodoLists
{
    public record GetAllTodoListsResponse
    {
        public IReadOnlyCollection<GetAllTodoListsDto> TodoLists { get; init; }

        public static GetAllTodoListsResponse Create(IList<GetAllTodoListsDto> todoLists)
        {
            return new GetAllTodoListsResponse
            {
                TodoLists = new ReadOnlyCollection<GetAllTodoListsDto>(todoLists)
            };
        }
    }
}
