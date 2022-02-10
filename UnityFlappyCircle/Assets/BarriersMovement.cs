using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarriersMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _destroyXСoordinate;

    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if(transform.position.x < _destroyXСoordinate)
        {
            Destroy(gameObject);
        }
    }
}
