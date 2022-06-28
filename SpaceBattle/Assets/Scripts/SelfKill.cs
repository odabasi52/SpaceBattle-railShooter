using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfKill : MonoBehaviour
{
    void Awake() 
    {
       Destroy(gameObject , 1); 
    }
}
