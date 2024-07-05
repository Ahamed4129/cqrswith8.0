using cqrswith8._0.Model;
using cqrswith8._0.Query;
using cqrswith8._0.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class GetAllTestsQueryHandler : IRequestHandler<GetAllTestsQuery, List<Test>>
{
    private readonly ITestRepositoryace _testRepository;

    public GetAllTestsQueryHandler(ITestRepositoryace testRepository)
    {
        _testRepository = testRepository;
    }

    public async Task<List<Test>> Handle(GetAllTestsQuery request, CancellationToken cancellationToken)
    {
        return await _testRepository.GetAllAsync(request.PageNumber, request.PageSize, request.NameFilter);
    }
}
