using UnityEngine;

namespace View
{
    public class PlayerView : MonoBehaviour
    {
        public void SetPosition(Vector2 position)
        {
            Debug.Log($"Set position X {position.x} Y {position.y}");
            transform.position = position;
        }
    }
}