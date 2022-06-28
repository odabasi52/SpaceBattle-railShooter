using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    GameObject kill;
    void Start()
    {
        kill = GameObject.FindWithTag("music");
        Destroy(kill);     
    }

}
