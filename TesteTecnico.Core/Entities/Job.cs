namespace TesteTecnico.Core.Entities;

public class Job
{
    public Job(Guid id, string title, string description, string location, decimal salary)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Location = location;
        Salary = salary;
    }

    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Location { get; private set; }
    public decimal Salary { get; private set; }
}