namespace Domain.Entities;

public class Todo
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public User User { get; private set; }
}