using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward_Movement : MonoBehaviour
{
    public float Speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
