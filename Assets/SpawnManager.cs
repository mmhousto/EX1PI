using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject sphere; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SpawnSphere()
    {
        GameObject spawn = Instantiate(sphere, transform.position, Quaternion.identity) as GameObject;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnSphere();
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
