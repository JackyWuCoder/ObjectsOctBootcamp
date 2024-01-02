using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(Utilities.DEVICE_ID);
        Utilities.ShowDeviceID("LUCY");
        */
        Debug.Log(Utilities.CalculateSomeValue(5, 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
