using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            if (i < 2)
            {
                Debug.Log(i + " Boy ");
            }
            else
            {
                Debug.Log(i + " Boys ");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
