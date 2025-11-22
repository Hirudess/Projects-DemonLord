using FDK.Character;
using VContainer;
using VContainer.Unity;

public class RootLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<CharacterClassGameDataCollectionService>().As<ICharacterClassGameDataCollectionService>();
    }
}
