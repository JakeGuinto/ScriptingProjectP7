using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifstatements : MonoBehaviour
{
    float coffieTempurature = 85.0f;
    float hotLimitTempurature = 70.0f;
    float coldLimitTempurature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempuratureTest();

        coffieTempurature -= Time.deltaTime * 5f;
    }

    void TempuratureTest ()
    {
        //If the coffee's tempurature is greater than the hottest drinking tempurature...
        if (coffieTempurature > hotLimitTempurature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffie tempurature is less than the coldest drinking tempurature
        else if(coffieTempurature > coldLimitTempurature)
        {
            // ... do this.
            print("Coffee is too cold");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right");
        }
    }
}
