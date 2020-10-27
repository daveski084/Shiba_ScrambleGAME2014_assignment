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

/** Handles money logic and loads gameover scene. */
public class moneyBehaviour : MonoBehaviour
{

    public static int moneyValue;
    Text money;
    /** Initializes money at the start of the scene.  */
    void Start()
    {
        moneyValue = 0;
        money = GetComponent<Text>();
    }

    /** Updates the player's money. */
    void Update()
    {
        money.text = "Money: " + moneyValue;
    }
}
