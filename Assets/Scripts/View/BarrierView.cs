using UnityEngine;

namespace View
{
    public class BarrierView : MonoBehaviour
    {
        public void SetPosition(Vector2 position)
            => transform.position = position;

        public void Destroy() => Destroy(gameObject);
    }
}