using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = (new Vector2(0f, jumpForce));   
        }

        if (transform.position.y < -6 || transform.position.y > 5.3f)
        {
            GameOver();
        }           
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Barriers")
        {
            GameOver();
        } 

        // if(other.tag == "CounterTigger")
        // {
        //     counter.count++;
        // } 
    }
}
