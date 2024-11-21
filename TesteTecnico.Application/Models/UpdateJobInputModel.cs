namespace TesteTecnico.Application.Models;

public class UpdateJobInputModel
{
    public Guid IdJob { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public decimal Salary { get; set; }
}