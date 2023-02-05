using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Out_Of_Bounds : MonoBehaviour
{
    public int points = 0;
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound)
        {
            Debug.Log("GameOver!");
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        // destroying animal when pizza hits it
        if (col.gameObject.tag == "Pizza")
        {
            Destroy(col.gameObject);
            points++;
        }
    }
}
