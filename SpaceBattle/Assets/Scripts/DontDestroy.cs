using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
     int music = FindObjectsOfType<DontDestroy>().Length; 
     if(music > 1)
     {
         Destroy(gameObject);
     }

     else 
     DontDestroyOnLoad(gameObject);

    }


}
