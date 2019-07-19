namespace DatingApp.API.Helpers
{
  public class MessageParams
  {
    private const int MaxPageSize = 50; //defeault value for maxpagesize
    public int PageNumber { get; set; } = 1;
    private int pageSize = 10; //default value
    public int PageSize
    {
      get { return pageSize; }
      set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
    }
    public int UserId { get; set; }
    public string MessageContainer { get; set; } = "Unread";
  }
}