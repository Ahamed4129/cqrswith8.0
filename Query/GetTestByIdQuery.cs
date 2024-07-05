using cqrswith8._0.Model;
using MediatR;

namespace cqrswith8._0.Handler
{
    public class GetTestByIdQuery : IRequest<Test>
    {
        public int Id { get; set; }
    }
}
    
