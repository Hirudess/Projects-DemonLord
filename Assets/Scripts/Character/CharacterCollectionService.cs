using UnityEngine.Scripting;

namespace FDK.Character
{
    public interface ICharacterCollectionService
    {
        ICharacterCollectionData CharacterCollection { get; }

        void Add(CharacterData characterData);
        void Remove(CharacterData characterData);
    }

    public class CharacterCollectionService : ICharacterCollectionService
    {
        public ICharacterCollectionData CharacterCollection { get; private set; }

        [Preserve]
        public CharacterCollectionService()
        {
            CharacterCollection = new CharacterCollectionData();
        }

        public void Add(CharacterData characterData)
        {
            CharacterCollection.Add(characterData);
        }

        public void Remove(CharacterData characterData)
        {
            CharacterCollection.Remove(characterData);
        }
    }
}
