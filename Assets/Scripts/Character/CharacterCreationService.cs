using FDK.Core;
using UnityEngine.Scripting;

namespace FDK.Character
{
    public class CharacterCreationService
    {
        private readonly ICharacterClassGameDataCollectionService _collectionService;
        private readonly ICharacterInventoryDataService _inventoryDataService;

        [Preserve]
        public CharacterCreationService(ICharacterClassGameDataCollectionService collectionService, ICharacterInventoryDataService inventoryService)
        {
            _collectionService = collectionService;
            _inventoryDataService = inventoryService;
        }

        public void Create(string name, CharacterClassGameData characterClass)
        {
            var characterCreated = new CharacterData(name, characterClass);
            _inventoryDataService.Add(characterCreated);
        }
    }
}
