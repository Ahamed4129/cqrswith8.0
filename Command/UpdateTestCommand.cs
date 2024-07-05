using cqrswith8._0.Model;
using MediatR;

namespace cqrswith8._0.Command
{
    public class UpdateTestCommand : IRequest<Test>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}
