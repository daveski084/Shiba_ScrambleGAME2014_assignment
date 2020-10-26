using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollision : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BoneBullet" && moneyBehaviour.moneyValue >= 200)
        {
            ScoreBehaviour.scoreNumber += 155;
            HPBehaviour.hitPoints += 20;
            moneyBehaviour.moneyValue -= 200;
            Debug.Log("Collsion Occured!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
