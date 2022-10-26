namespace GreglistSharp.Repositories;
public class JobsRepository
{
  private readonly IDbConnection _db;

  public JobsRepository(IDbConnection db)
  {
    _db = db;
  }
  public List<Job> GetJobs()
  {
    var sql = "SELECT * FROM jobs";
    return _db.Query<Job>(sql).ToList();
  }

}