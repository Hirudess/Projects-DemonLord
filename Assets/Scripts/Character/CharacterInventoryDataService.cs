using FDK.Core;

namespace FDK.Character
{
    public interface ICharacterInventoryDataService
    {
        CharacterInventoryData CharacterInventoryData { get; }

        void Add(CharacterData characterData);
        void GetData(CharacterData characterData);
        void Remove(CharacterData characterData);
    }

    public class CharacterInventoryDataService : BaseService, ICharacterInventoryDataService
    {
        public CharacterInventoryData CharacterInventoryData { get; private set; }

        public CharacterInventoryDataService()
        {

        }

        public void Add(CharacterData characterData)
        {
            CharacterInventoryData.Add(characterData);
        }

        public void Remove(CharacterData characterData)
        {
            CharacterInventoryData.Equals(characterData);
        }

        public void GetData(CharacterData characterData)
        {
            CharacterInventoryData.GetData(characterData);
        }
    }
}
