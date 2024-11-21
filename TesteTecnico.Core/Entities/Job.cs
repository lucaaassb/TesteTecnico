namespace TesteTecnico.Core.Entities;

public class Job
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Location { get; private set; }
    public decimal Salary { get; private set; }
}