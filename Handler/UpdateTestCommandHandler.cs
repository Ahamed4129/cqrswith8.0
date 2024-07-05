    using cqrswith8._0.Command;
    using cqrswith8._0.Model;
    using cqrswith8._0.Repository;
    using MediatR;

    using System.Threading;
    using System.Threading.Tasks;

    public class UpdateTestCommandHandler : IRequestHandler<UpdateTestCommand, Test>
    {
        private readonly ITestRepositoryace _testRepository;

        public UpdateTestCommandHandler(ITestRepositoryace testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<Test> Handle(UpdateTestCommand request, CancellationToken cancellationToken)
        {
            var entity = await _testRepository.GetByIdAsync(request.Id);
            if (entity == null)
                return null;

            entity.Name = request.Name;
            return await _testRepository.UpdateAsync(entity);
        }
    }
