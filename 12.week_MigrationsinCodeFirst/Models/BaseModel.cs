namespace _12.week_MigrationsinCodeFirst.Models
{
    public abstract class BaseModel<T>
    {
        public T Id { get; set; }
    }
}
