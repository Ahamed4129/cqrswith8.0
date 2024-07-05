using cqrswith8._0.Command;
using cqrswith8._0.Model;
using cqrswith8._0.Repository;
using MediatR;

using System.Threading;
using System.Threading.Tasks;

public class CreateTestCommandHandler : IRequestHandler<CreateTestCommand, Test>
{
    private readonly ITestRepositoryace _testRepository;

    public CreateTestCommandHandler(ITestRepositoryace testRepository)
    {
        _testRepository = testRepository;
    }

    public async Task<Test> Handle(CreateTestCommand request, CancellationToken cancellationToken)
    {
        var entity = new Test { Name = request.Name };
        return await _testRepository.CreateAsync(entity);
    }
}
