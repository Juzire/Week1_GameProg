using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public int healthPoints;
    public int constitution;
    // Start is called before the first frame update
    void Start()
    {
        healthPoints = constitution * 6;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
