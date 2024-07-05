//using cqrswith8._0.Model;
//using MediatR;
namespace cqrswith8._0.Handler;
using cqrswith8._0.Handler;
using cqrswith8._0.Model;
using cqrswith8._0.Repository;
using MediatR;

using System.Threading;
using System.Threading.Tasks;

public class GetTestByIdHandler : IRequestHandler<GetTestByIdQuery, Test>
{
    private readonly ITestRepositoryace _testRepository;

    public GetTestByIdHandler(ITestRepositoryace testRepository)
    {
        _testRepository = testRepository;
    }

    public async Task<Test> Handle(GetTestByIdQuery request, CancellationToken cancellationToken)
    {
        return await _testRepository.GetByIdAsync(request.Id);
    }
}

