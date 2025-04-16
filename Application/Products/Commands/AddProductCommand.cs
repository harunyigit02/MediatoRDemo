using MediatoRTestApi.Domain.Entities;
using MediatR;

namespace MediatoRTestApi.Commands
{
    public class AddProductCommand:IRequest<Product>
    {
        public string Name { get; set; }
    }
}
