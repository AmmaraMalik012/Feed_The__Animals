using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Count : MonoBehaviour
{
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(Score);*/
    }

    void OnTriggerEnter(Collider col)
    {
        
        /*Debug.Log("Target was Hit!");*/
        // if pizza hit the animals
        if (col.gameObject.tag == "Animal")
        {
            ScoreCount();
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Pizza")
        {
            Destroy(gameObject);
        }
    }
    void ScoreCount()
    {
        Score++;
    }
}
