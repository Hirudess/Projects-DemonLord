using FDK.Character;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class RootLifetimeScope : LifetimeScope
{
    [SerializeField] private CharacterClassCollectionRef _characterClassCollectionRef;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(_characterClassCollectionRef);
        builder.RegisterEntryPoint<CharacterClassGameDataCollectionService>().As<ICharacterClassGameDataCollectionService>();
    }
}
