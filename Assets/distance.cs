using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    
    void Distance()
    {
            float dist = Vector3.Distance(other.position, transform.position);
        //print("Distance: " + dist);
        GameManager.instance.setdistance(dist);
        if (dist < 2)
        {
            GameManager.instance.LoadScene("win");
            print("goal");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance();
        print(GameManager.instance.getdistance());
        
    }
    public Transform other;

    

}
