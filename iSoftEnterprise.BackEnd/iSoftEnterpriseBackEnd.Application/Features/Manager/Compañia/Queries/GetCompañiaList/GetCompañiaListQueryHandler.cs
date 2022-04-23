using AutoMapper;
using iSoftEnterpriseBackEnd.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSoftEnterpriseBackEnd.Application.Features.Manager.Compañia.Queries.GetCompañiaList
{
  public  class GetCompañiaListQueryHandler : IRequestHandler<GetCompañiaListQuery, List<iSoftEnterprise.BackEnd.Domain.Manager.Compañia>>
  {

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCompañiaListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
      _unitOfWork = unitOfWork;
      _mapper = mapper;
    }

    public async Task<List<iSoftEnterprise.BackEnd.Domain.Manager.Compañia>> Handle(GetCompañiaListQuery request, CancellationToken cancellationToken)
    {
      var videoList = await _unitOfWork.VideoRepository.GetVideoByUserName(request._UserName);
      return _mapper.Map<List<VideosVm>>(videoList);
    }

  }
}
