namespace ToDoApp.SoapApi.CoreWcf;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo, ToDoResponse>();
    }
}
