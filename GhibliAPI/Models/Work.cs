,namespace GhibliAPI.Models
{
  public class Work
  {
    public long Id { get; set; }
    public int Year { get; set; }
    public string Director { get; set; } = string.Empty;
    public string Music { get; set; } = string.Empty;
    public int RunTime { get; set; }
    public int Rating { get; set; }

    //list of producers
  }
}