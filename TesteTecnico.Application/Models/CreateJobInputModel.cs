namespace TesteTecnico.Application.Models;

public class CreateJobInputModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public decimal Salary { get; set; }
}