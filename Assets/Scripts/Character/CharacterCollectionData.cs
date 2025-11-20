using System.Collections.Generic;
using System.Linq;

namespace FDK.Character
{
    public interface ICharacterCollectionData
    {
        List<CharacterData> CharacterInventory { get; }

        void Add(CharacterData data);
        void Remove(CharacterData data);
    }

    public class CharacterCollectionData : ICharacterCollectionData
    {
        public List<CharacterData> CharacterInventory { get; private set; }

        public CharacterCollectionData()
        {
            CharacterInventory = new List<CharacterData>();
        }

        public void Add(CharacterData data)
        {
            if (CharacterInventory.Contains(data)) return;
            CharacterInventory.Add(data);
        }

        public void Remove(CharacterData data)
        {
            var character = CharacterInventory.FirstOrDefault(x => x.Id == data.Id);
            if (character == null) return;
            CharacterInventory.Remove(data);
        }
    }
}
