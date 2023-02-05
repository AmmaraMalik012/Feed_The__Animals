using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float horizontalInput;
    private float Speed = 15.0f;
    public float xRange = 20;
    public GameObject prefabProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Making boundary on left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Making boundary on right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Getting input and moving the player along x axis(Horizontally)
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate (Vector3.right * horizontalInput * Time.deltaTime * Speed);

        // Launch projectile from player
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabProjectile, transform.position, prefabProjectile.transform.rotation);
        }
    }
}
