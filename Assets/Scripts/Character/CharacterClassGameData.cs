using UnityEngine;

namespace FDK.Core
{
    [CreateAssetMenu(fileName = "Class", menuName = "FDK/Character/Character Class")]
    public class CharacterClassGameData : BaseGameData
    {
        [Space]
        public string Name;
        public string Description;
    }
}
