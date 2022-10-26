namespace GreglistSharp.Controllers;
public class JobsController : ControllerBase
{
  private readonly JobsService _jobsService;

  public JobsController(JobsService jobsService)
  {
    this._jobsService = jobsService;
  }
  [HttpGet]
  public ActionResult<List<Job>> Get()
  {
    try
    {
      List<Job> jobs = _jobsService.GetJobs();
      return Ok(jobs);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}