using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    int numEnimies = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEnimies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }   
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
