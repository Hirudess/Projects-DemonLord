using FDK.Core;
using FDK.Core.GameData;
using UnityEngine;

namespace FDK.Character
{
    [CreateAssetMenu(fileName = "Class", menuName = "FDK/Character/Character Class Collection")]
    [System.Serializable]
    public class CharacterClassGameDataCollection : BaseGameDataCollection<CharacterClassGameData>
    {
    }
}
