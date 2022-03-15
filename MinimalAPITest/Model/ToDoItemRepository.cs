namespace MinimalAPITest.Model
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private List<ToDoItem> _toDoItems;

        public ToDoItemRepository()
        {
            _toDoItems = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Id = 1,
                    Title = "First",
                    Description = "First Desc",
                    DateCreated = DateTime.Now
                },
                new ToDoItem
                {
                    Id = 2,
                    Title = "Second",
                    Description = "Second Desc",
                    DateCreated = DateTime.Now
                },
                new ToDoItem
                {
                    Id = 1,
                    Title = "Third",
                    Description = "Third Desc",
                    DateCreated = DateTime.Now
                }
            };
        }
        public ToDoItem GetById(int id)
        {
            return _toDoItems.FirstOrDefault(i => i.Id == id);
        }

        public List<ToDoItem> GetAll()
        {
            return _toDoItems;
        }

        public void CreateNewToDoItem(ToDoItem item)
        {
            int lastId = _toDoItems.Max(i => i.Id);
            item.Id += lastId;
            _toDoItems.Add(item);
        }
    }
}
