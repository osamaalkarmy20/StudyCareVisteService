namespace StudyCareVisteService.Abstraction.Entity
{
    public class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

}
