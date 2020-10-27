/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Adds appropriate points and destroys gameobject.
*
* Last modified      : 20/10/25
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201024    David Gasinec        Created script. 
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Adds appropriate points and destroys gameobject. */
public class EnemyCollisionBehaviour : MonoBehaviour
{
    /** Adds appropriate points and destroys gameobject. */
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
