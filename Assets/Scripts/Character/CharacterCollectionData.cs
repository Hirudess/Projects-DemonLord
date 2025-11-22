using FDK.Core;

namespace FDK.Character
{
    public interface ICharacterCollectionData : ICollectionData<ICharacterData>
    {

    }

    public class CharacterCollectionData : BaseCollectionData<ICharacterData>, ICharacterCollectionData
    {
    }
}
