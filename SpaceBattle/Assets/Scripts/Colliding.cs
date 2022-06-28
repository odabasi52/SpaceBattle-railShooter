using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Colliding : MonoBehaviour
{   AudioSource AS;
    [SerializeField] ParticleSystem ps;
    [SerializeField] AudioClip dead;
    void Start() 
    {
        Cursor.visible = false;
        AS= GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {  
        
       if(other.gameObject.tag == "Finish")
       {
        SceneManager.LoadScene(0);
        return;
       }
       GetComponent<MeshRenderer>().enabled = false;
       Invoke ("Restart", 0.5f);
       GetComponent<Moving>().enabled = false;
       if(!AS.isPlaying)
       {
          AS.PlayOneShot(dead); 
       }
       if(!ps.isPlaying)
       {
           ps.Play();
       }
    }
    
     void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
