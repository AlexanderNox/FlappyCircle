using Model;
using UnityEngine;
using Zenject;

namespace Presenters.Barrier
{
    public class BarrierFactoryPresenter : MonoBehaviour
    {
        private BarrierFactory _barrierFactory;

        [Inject]
        private void Construct(BarrierFactory barrierFactory)
        {
            _barrierFactory = barrierFactory;
        }

        private void Start() => _barrierFactory.Start();
    }
}