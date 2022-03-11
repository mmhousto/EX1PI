using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{

    private const float speed = 10f;
    public Material red;
    public Material blue;
    public Material green;
    private Material[] matList;
    
    // Start is called before the first frame update
    void Start()
    {
        matList = new Material[3];
        matList[0] = red;
        matList[1] = green;
        matList[2] = blue;
        var rand = Random.Range(0, 3);
        var thisRend = GetComponent<Renderer>();
        thisRend.material = matList[rand];

        var rb = GetComponent<Rigidbody>();
        float randomDir = Random.Range(-180.0f, 180.0f);
        rb.velocity = new Vector3(randomDir, randomDir, randomDir) * speed * Time.deltaTime;
        StartCoroutine(destroyObject());

    }

    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
