using System;

namespace FDK.Core
{
    public interface IPlayerData
    {
        string Id { get; }
    }

    public abstract class BasePlayerData : IPlayerData
    {
        public string Id { get; private set; }

        public BasePlayerData()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
