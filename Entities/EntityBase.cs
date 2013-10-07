namespace Entities
{
    public abstract class EntityBase : IObjectState
    {
        public ObjectState State { get; set; }
    }
}
