

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    private float dist;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }


    }

    private void Start()
    {
       
    }

    
    

    public IEnumerator End()
    {
        print("called");
        yield return new WaitForSeconds(2);
        LoadScene("mainScene");
    }

    public void LoadScene(string Level)
    {
        if (Level == "win")
        {
            SceneManager.LoadScene("win");
        }
        if (Level == "mainScene")
        {
            SceneManager.LoadScene("mainScene");
        }

    }

    public void setdistance(float dis)
    {
        dist = dis;
    }
    public float getdistance()
    {
        return dist;
    }
}
