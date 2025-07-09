namespace ToDoApp.SoapApi.CoreWcf.DataContracts;

[DataContract]
public class ToDoRequest
{
    [DataMember]
    public string ToDoName { get; set; } = null!;
}
