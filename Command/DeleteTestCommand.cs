using MediatR;

namespace cqrswith8._0.Command
{
    public class DeleteTestCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
   
}
