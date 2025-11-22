using FDK.Core;
using UnityEngine;

namespace FDK.Character
{
    public interface ICharacterClassGameDataCollectionService
    {
        CharacterClassGameData GetCharacterClass(string id);
    }

    public struct CharacterClassCollectionRef
    {

    }

    public class CharacterClassGameDataCollectionService : BaseGameDataCollectionService<CharacterClassGameData>, ICharacterClassGameDataCollectionService
    {
        private readonly TextAsset _characterClassCollectionRef;

        public CharacterClassGameDataCollectionService()
        {
            var classGameDataCollection = JsonUtility.FromJson<CharacterClassGameDataCollection>(_characterClassCollectionRef.text);
            if (classGameDataCollection == null)
            {
                return;
            }
            Collection = classGameDataCollection;
        }

        public CharacterClassGameData GetCharacterClass(string id)
        {
            var characterClass = Collection.GetItem(id);
            if (characterClass == null) return null;
            return characterClass;
        }
    }
}
