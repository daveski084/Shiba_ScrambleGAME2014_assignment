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
public class itemCollision : MonoBehaviour
{
    /** Adds appropriate points and destroys gameobject. */
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
