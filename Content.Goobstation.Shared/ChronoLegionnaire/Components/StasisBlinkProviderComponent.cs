using Content.Goobstation.Shared.ChronoLegionnaire.EntitySystems;
using Content.Shared.Actions;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Goobstation.Shared.ChronoLegionnaire.Components
{
    /// <summary>
    /// Marks an clothing that will give stasis blink ability to wearer
    /// </summary>
    [RegisterComponent, NetworkedComponent, Access(typeof(SharedStasisBlinkProviderSystem)), AutoGenerateComponentState]
    public sealed partial class StasisBlinkProviderComponent : Component
    {
        /// <summary>
        /// The action blink id.
        /// </summary>
        [DataField]
        public EntProtoId<WorldTargetActionComponent> BlinkAction = "ActionChronoBlink";

        [DataField, AutoNetworkedField]
        public EntityUid? BlinkActionEntity;
    }
}
