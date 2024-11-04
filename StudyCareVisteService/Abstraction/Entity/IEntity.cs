using System.Security.Principal;

namespace StudyCareVisteService.Abstraction.Entity
{
    public interface IEntity <T> : IEntity
    {
        T Id { get; set; }
    }
    public interface IEntity
    {

        public string?  CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
