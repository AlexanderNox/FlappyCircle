using System;
using UnityEngine;

namespace Presenters.Barrier
{
    public class BarrierPresenterPart : MonoBehaviour
    {
        public event Action<Collider2D> OnTriggerEntered2D;

        private void OnTriggerEnter2D(Collider2D col)
        {
            OnTriggerEntered2D.Invoke(col);
        }
    }
}
