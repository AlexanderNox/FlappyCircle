using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed;
    [SerializeField] private GameObject _barriers;
    [SerializeField] private Transform _upperBorder;
    [SerializeField] private Transform _lowerBorder;
     
    void Start()
    {
        StartCoroutine(SpawnCoroutin(spawnSpeed));     
    }

    private IEnumerator SpawnCoroutin(float waitTime)
    {
        while(true)
        {
            Instantiate(_barriers, new Vector3(transform.position.x, Random.Range(_lowerBorder.position.y, _upperBorder.position.y), transform.position.z), transform.rotation); 
            yield return new WaitForSeconds(waitTime);
        }
       
    }
}
