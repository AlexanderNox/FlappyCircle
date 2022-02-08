using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public float spawnSpeed;
    [SerializeField] private GameObject barriers;
     
    void Start()
    {
        StartCoroutine(SpawnCoroutin(spawnSpeed));     
    }

    private IEnumerator SpawnCoroutin(float waitTime)
    {
        while(true)
        {
            Instantiate(barriers, new Vector3(transform.position.x, Random.Range(-2f, 3.7f), transform.position.z), transform.rotation); 
            yield return new WaitForSeconds(waitTime);
        }
       
    }
}
