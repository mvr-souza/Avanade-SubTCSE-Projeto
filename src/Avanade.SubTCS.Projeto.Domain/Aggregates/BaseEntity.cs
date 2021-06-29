namespace Avanade.SubTCS.Projeto.Domain.Aggregates
{
    public record BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
