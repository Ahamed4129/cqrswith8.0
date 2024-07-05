using cqrswith8._0.Model;
using MediatR;

namespace cqrswith8._0.Command
{
    public class CreateTestCommand : IRequest<Test>
    {
        public string Name { get; set; }
    }
   
}
