using System.Collections.Generic;
using System.Linq;

namespace FDK.Core
{
    public interface ICollectionData<T> where T : IPlayerData
    {
        List<T> Collection { get; }

        void AddData(T data);
        void RemoveData(T data);
        T GetData(string id);
        T GetData(T data);
    }

    public abstract class BaseCollectionData<T> : ICollectionData<T> where T : IPlayerData
    {
        public List<T> Collection { get; private set; }

        public BaseCollectionData()
        {
            Collection = new List<T>();
        }

        public void AddData(T data)
        {
            if (Collection.Contains(data)) return;
            Collection.Add(data);
        }

        public void RemoveData(T data)
        {
            var character = Collection.FirstOrDefault(x => x.Id == data.Id);
            if (character == null) return;
            Collection.Remove(data);
        }

        public T GetData(T data)
        {
            return Collection.FirstOrDefault(foundData => foundData.Equals(data));
        }

        public T GetData(string id)
        {
            return Collection.FirstOrDefault(foundData => foundData.Id == id);
        }
    }
}
