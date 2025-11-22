using FDK.Core;
using UnityEngine;
using VContainer.Unity;

namespace FDK.Character
{
    public interface ICharacterClassGameDataCollectionService
    {
        CharacterClassGameData GetCharacterClass(string id);
    }

    [System.Serializable]
    public struct CharacterClassCollectionRef
    {
        public CharacterClassGameDataCollection CharacterClassData;
    }

    public class CharacterClassGameDataCollectionService : BaseGameDataCollectionService<CharacterClassGameData>, ICharacterClassGameDataCollectionService, IStartable
    {
        public CharacterClassGameDataCollectionService(CharacterClassCollectionRef classRef)
        {
            Collection = classRef.CharacterClassData;
            SetReady(true);
        }

        public CharacterClassGameData GetCharacterClass(string id)
        {
            var characterClass = Collection.GetItem(id);
            if (characterClass == null) return null;
            return characterClass;
        }

        public void Start()
        {
        }
    }
}
