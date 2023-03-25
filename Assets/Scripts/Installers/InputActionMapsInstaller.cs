using Zenject;

namespace Installers
{
    public class InputActionInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InputActionMaps inputActionMaps = new InputActionMaps();
            inputActionMaps.Enable();
        
            Container
                .Bind<InputActionMaps>()
                .FromInstance(inputActionMaps)
                .AsSingle();
        }
    }
}