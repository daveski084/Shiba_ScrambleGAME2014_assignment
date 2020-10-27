/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Dog bowl collsion logic.
*
* Last modified      : 20/10/25
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201024    David Gasinec        Created script. 
*
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Dog bowl collsion and sound effects. */
public class dogFoodBowlScript : MonoBehaviour
{
    public AudioSource dogbark;

    /** Play sound when either enemy type collides.  */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy2" || other.gameObject.tag == "Enemy1")
        {
            dogbark.Play();
            Debug.Log("Collsion Occured!");
        }

    }
}
