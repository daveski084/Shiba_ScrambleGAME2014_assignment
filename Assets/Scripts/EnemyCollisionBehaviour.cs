using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionBehaviour : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BoneBullet")
        {
            ScoreBehaviour.scoreNumber += 25;
            moneyBehaviour.moneyValue += 10;
            Debug.Log("Collsion Occured!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "DogFood")
        {
            Debug.Log("Collsion Occured with Dog Food!");
            HPBehaviour.hitPoints -= 20;
            Destroy(gameObject);
        }

    }

}
