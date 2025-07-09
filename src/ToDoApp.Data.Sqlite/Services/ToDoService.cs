namespace ToDoApp.Data.Sqlite.Services;

public class ToDoService(AppDbContext dbContext) : ITodoService
{

    public async Task<IEnumerable<ToDo>?> GetToDosAsync()
    {
        return await dbContext.ToDos.ToListAsync();        
    }

    public async Task<ToDo?> GetToDoByIdAsync(int id)
    {
        return await dbContext.ToDos.FindAsync(id);
    }

    public async Task<ToDo?> AddToDoAsync(ToDo toDo)
    {
        dbContext.ToDos.Add(toDo);
        await dbContext.SaveChangesAsync();
        return toDo;
    }

    public async Task<ToDo?> UpdateToDoAsync(ToDo toDo)
    {
       var existingtoDo = await dbContext.ToDos.FindAsync(toDo.Id);
        if (existingtoDo!=null)
        { 
            dbContext.Entry(toDo).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return toDo;
        }
        return null;        
    }

    public async Task<bool> DeleteToDoByIdAsync(int id)
    {
        var existingtoDo = await dbContext.ToDos.FindAsync(id);
        if (existingtoDo != null)
        {
            dbContext.ToDos.Remove(existingtoDo);
            await dbContext.SaveChangesAsync();
            return true;
        }
        return false;
    }
}
