using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barriers : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if(transform.position.x < -16)
        {
            Destroy(gameObject);
        }
    }
}
