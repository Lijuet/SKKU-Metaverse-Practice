using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{   
    public float speed = 5;
    float currentTime;
    public float deleteTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.up;
        transform.position += dir * speed * Time.deltaTime;

        currentTime += Time.deltaTime;

        if (currentTime > deleteTime) {
            Destroy(gameObject);
            currentTime = 0;
        }
    }
}
