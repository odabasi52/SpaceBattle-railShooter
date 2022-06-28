using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] GameObject EnemyDeath;
   [SerializeField] GameObject EnemyHit;
   [SerializeField] int scoreKill = 15;   
   [SerializeField] int scoreHit = 5;

   [SerializeField] int health = 5;
   [SerializeField] int hitGiven = 1;
   GameObject spawner; 
 
   Score scoreBoard;
   void Start() 
   {
      spawner = GameObject.FindWithTag("Spawner");

      scoreBoard = FindObjectOfType<Score>();

      gameObject.AddComponent<Rigidbody>();
      GetComponent<Rigidbody>().useGravity = false;
   }
    void OnParticleCollision(GameObject other)
    {
        

        HealthBar();
    }

     void HealthBar()
    {
        hitGiven++;

        if (hitGiven > health)
        {
            GameObject vfx = Instantiate(EnemyDeath, transform.position, Quaternion.identity);
            vfx.transform.parent = spawner.transform;
            Destroy(gameObject);
            scoreBoard.Scoring(scoreKill);
        }

        if (hitGiven <= health)
        {
            GameObject hitVFX = Instantiate(EnemyHit, transform.position, Quaternion.identity);
            hitVFX.transform.parent = spawner.transform;
            scoreBoard.Scoring(scoreHit);
        }
    }
}
