using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHeart : MonoBehaviour
{
    public GameObject heartFactory;
    public GameObject heartPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            GameObject heart = Instantiate(heartFactory);
            heart.transform.position = heartPosition.transform.position;
        }
    }
}
