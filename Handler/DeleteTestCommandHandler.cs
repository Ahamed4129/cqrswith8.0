    using cqrswith8._0.Command;
    using cqrswith8._0.Repository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteTestCommandHandler : IRequestHandler<DeleteTestCommand, bool>
    {
        private readonly ITestRepositoryace _testRepository;

        public DeleteTestCommandHandler(ITestRepositoryace testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<bool> Handle(DeleteTestCommand request, CancellationToken cancellationToken)
        {
            return await _testRepository.DeleteAsync(request.Id);
        }
    }
