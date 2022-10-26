namespace GreglistSharp.Services;
public class JobsService
{
  private readonly JobsRepository _jobsRepo;

  public JobsService(JobsRepository jobsRepo)
  {
    _jobsRepo = jobsRepo;
  }
  public List<Job> GetJobs()
  {
    return _jobsRepo.GetJobs();
  }
}