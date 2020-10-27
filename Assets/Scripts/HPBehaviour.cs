/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Controls HP logic.
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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/** Handles hitpoint logic and loads gameover scene. */
public class HPBehaviour : MonoBehaviour
{

    public static int hitPoints;
    Text HP;

    /** Initializes hit points at the start of the scene.  */
    void Start()
    {
        hitPoints = 100;
        HP = GetComponent<Text>();
    }

    /** Updates the player's hit points and loads gameover. */
    void Update()
    {
        HP.text = "HP: " + hitPoints;

        if(hitPoints <= 0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
