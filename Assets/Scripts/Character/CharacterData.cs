using FDK.Core;

namespace FDK.Character
{
    public class CharacterData : BaseCharacterData
    {
        public string Name { get; set; }
        public readonly CharacterClassGameData ClassData;

        public CharacterData(string name, CharacterClassGameData classGameData)
        {
            Name = name;
            ClassData = classGameData;
        }
    }
}
