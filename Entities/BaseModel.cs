using System;

namespace Entities
{
    public abstract class BaseModel<T> : IObjectState where T : class
    {
        public string UserAdded { get; set; }
        public DateTime? DateAdded { get; set; }
        public string UserEdited { get; set; }
        public DateTime? DateEdited { get; set; }

        public ObjectState State { get; set; }
    }
}
