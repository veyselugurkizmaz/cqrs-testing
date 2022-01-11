using CQRSTesting.Application.Infrastructure.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSTesting.Application.Services.TodoLists.GetAllTodoLists
{
    public class GetAllTodoListsHandler : IRequestHandler<GetAllTodoListsRequest, GetAllTodoListsResponse>
    {
        private readonly IDbContext _dbContext;
        public GetAllTodoListsHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetAllTodoListsResponse> Handle(GetAllTodoListsRequest request, CancellationToken cancellationToken)
        {
            var items = _dbContext.TodoLists.Select(x=>new GetAllTodoListsDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return GetAllTodoListsResponse.Create(items);
        }
    }
}
