namespace Exercise06.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
public class Info
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Email { get; set; }
    public string Height { get; set; }
    public string Tiebreaker { get; set; }
}