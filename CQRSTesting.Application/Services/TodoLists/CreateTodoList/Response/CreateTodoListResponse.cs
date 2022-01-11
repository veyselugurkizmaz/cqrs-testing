namespace CQRSTesting.Application.Services.TodoLists.CreateTodoList
{
    public record CreateTodoListResponse
    {
        public int Id { get; init; }

        public static CreateTodoListResponse Create(int id)
        {
            return new CreateTodoListResponse { Id = id };
        }
    }
}
