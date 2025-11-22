using FDK.Core.GameData;
using UnityEngine.Scripting;

namespace FDK.Core
{
    public abstract class BaseGameDataCollectionService<T> : BaseService where T : BaseGameData
    {
        public BaseGameDataCollection<T> Collection { get; protected set; }

        [Preserve]
        public BaseGameDataCollectionService()
        {
        }
    }
}
