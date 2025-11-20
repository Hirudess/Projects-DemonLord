using System;

namespace FDK.Character
{
    public abstract class BaseEntityData
    {
        public BaseEntityData()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id;
    }
}
