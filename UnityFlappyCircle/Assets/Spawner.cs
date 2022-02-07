using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject barriers;
    public float spawnSpeed;
  
    void Start()
    {
        StartCoroutine(Co_Spawner(spawnSpeed));     
    }

    private IEnumerator Co_Spawner(float waitTime)
    {
        while(true)
        {
            Instantiate(barriers, new Vector3(transform.position.x, Random.Range(-2f, 3.7f), transform.position.z), transform.rotation); 
            yield return new WaitForSeconds(waitTime);
        }
       
    }
}
