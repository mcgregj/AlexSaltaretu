using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaunatordibere : MonoBehaviour
{
    public GameObject bere;         
    public float spawnRate = 2; 
    private float timer = 0;       
    public float heightOffset = 50; 

    void Start()
    {
        spawnbere(); 
    }

    void Update()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; 
            
        }
        else
        {
            spawnbere();  
            timer = 0;  
        }
    }

    void spawnbere()
    {
        
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
       
        Instantiate(bere, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}