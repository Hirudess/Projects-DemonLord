using FDK.Core;

namespace FDK.Character
{
    public interface ICharacterData : IPlayerData
    {
        string Name { get; }
        CharacterClassGameData ClassData { get; }
    }

    public class CharacterData : BaseCharacterData, ICharacterData
    {
        public string Name { get; private set; }
        public CharacterClassGameData ClassData { get; private set; }


        public CharacterData(string name, CharacterClassGameData classGameData)
        {
            Name = name;
            ClassData = classGameData;
        }
    }
}
