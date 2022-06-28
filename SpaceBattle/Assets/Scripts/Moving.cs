using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{
[Header("Speed Settings")]
[Tooltip("Changing ship speed")] [SerializeField] float speed = 30;

[Header("Position Rotation Settings")]
[Tooltip("Changing up down rotation by position")][SerializeField] float positionPitch = -0.1f;

[Header("Movement Rotation Settings")]
[Tooltip("Changing up down rotation by movement")][SerializeField] float controlPitch = -25f;
[Tooltip("Changing roll rotation by movement")][SerializeField] float controlRoll = -30f;


[Header("Arrays GameObjects")]
[Tooltip("Gettin all objects in lasers")][SerializeField] ParticleSystem[] lasers;

float X , Y;

    void Update()
    {
        ClampnAxis();
        LocalRotation();
        Shooting();
    }
    
     void LocalRotation()
    {

        float pitch = transform.position.y *positionPitch + Y*controlPitch; //pitch yokuş//
        float roll =   X*controlRoll;

        transform.localRotation = Quaternion.Euler(pitch , 0 , roll);


    }
        

     void ClampnAxis()
    {  //float yerine direk X şeklinde yazıp yukarıda float olarak tanımlarsak 
       //diğer voidlerdede kullanılabilir
        X = Input.GetAxis("Horizontal");
        float xSet = X * Time.deltaTime * speed;
        float newX = transform.localPosition.x + xSet;
        float clampX = Mathf.Clamp(newX, -15, 12);

        Y = Input.GetAxis("Vertical"); 
        float ySet =  Y * Time.deltaTime * speed;
        float newY = transform.localPosition.y + ySet;
        float clampY = Mathf.Clamp(newY, -7, 9);

        transform.localPosition = new Vector3(clampX, clampY, transform.localPosition.z);
    }



   
     void Shooting()
    {   
     if(Input.GetButton("Fire1"))
        {
            LaserActive(true);
        }
        else
        {
            LaserActive(false);
        }
    }




    void LaserActive(bool emissionActive)
    {
      foreach(ParticleSystem  laser in lasers)
      {
      var emissionModule = laser.GetComponent<ParticleSystem>().emission;
         emissionModule.enabled = emissionActive;
      }
    }
}
