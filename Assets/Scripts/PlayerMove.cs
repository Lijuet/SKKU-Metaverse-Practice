using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 playerVelocity;
    public float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    float h, v, h1, v1;
    float speed = 4.0f; 
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        // Cursor visible
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        h1 = Input.GetAxis("Mouse X") * 2.0f;
        v1 = Input.GetAxis("Mouse Y") * 2.0f;

        transform.Rotate(0, h1, 0);

        transform.Translate(h, 0, v);
        
        // Changes the height position of the player..
        // if (Input.GetButtonDown("Jump")){
        //     playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //     playerVelocity.y += gravityValue * Time.deltaTime;
        //     transform.position += playerVelocity * Time.deltaTime;
        // }
    }
}
