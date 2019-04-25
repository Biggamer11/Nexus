using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calltimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(GameManager.instance.End());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
