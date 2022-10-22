using DddMvc.Domain.ValueObjects;
namespace DddMvc.Domain.Entities
{
    public class User : AggregateRoot
    {
        public Address Address { get; set; }
    }


}