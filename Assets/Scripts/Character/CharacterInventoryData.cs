using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;

namespace FDK.Character
{
    public interface ICharacterInventoryData
    {
        void Add(CharacterData data);
        void Remove(CharacterData data);
        CharacterData GetData(CharacterData data);
        CharacterData GetData(string id);
    }

    public class CharacterInventoryData : ICharacterInventoryData
    {
        public List<CharacterData> Inventory = new();
        public int MaxSlot;

        [Preserve]
        public CharacterInventoryData()
        {

        }

        public void Add(CharacterData data)
        {
            if (IsFull()) return;
            if (Inventory.Contains(data)) { return; }
            Inventory.Add(data);
        }

        public void Remove(CharacterData data)
        {
            var characterData = GetData(data);
            if (characterData == null) { return; }
            Inventory.Remove(characterData);
        }
        public CharacterData GetData(CharacterData data)
        {
            return Inventory.FirstOrDefault(foundData => foundData.Equals(data));
        }

        public CharacterData GetData(string id)
        {
            return Inventory.FirstOrDefault(foundData => foundData.Id == id);
        }

        private bool IsFull()
        {
            return Inventory.Count >= MaxSlot - 1;
        }
    }
}
