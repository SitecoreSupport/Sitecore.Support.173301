namespace Sitecore.Support.Initialize
{
  using System.Net;
  using Pipelines;

  public class EnableTls12
  {
    public void Process(PipelineArgs args)
    {
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
    }
  }
}