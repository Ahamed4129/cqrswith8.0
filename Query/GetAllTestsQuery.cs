using cqrswith8._0.Model;
using MediatR;

namespace cqrswith8._0.Query
{
    public class GetAllTestsQuery : IRequest<List<Test>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string NameFilter { get; set; }

    }
    
    
}
