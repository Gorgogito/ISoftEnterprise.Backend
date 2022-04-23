using MediatR;

namespace iSoftEnterpriseBackEnd.Application.Features.Manager.Compañia.Queries.GetCompañiaList
{
  public class GetCompañiaListQuery : IRequest<List<iSoftEnterprise.BackEnd.Domain.Manager.Compañia>>
  {
    public string _UserName { get; set; } = String.Empty;

    public GetCompañiaListQuery(string username)
    {
      _UserName = username ?? throw new ArgumentNullException(nameof(username));
    }
  }
}
