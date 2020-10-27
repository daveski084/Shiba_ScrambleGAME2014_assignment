/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Controls score logic.
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
using TMPro;

/** Handles score logic. */
public class ScoreBehaviour : MonoBehaviour
{
    public static int scoreNumber = 0;
    Text score;

   
    void Start()
    {
        score = GetComponent<Text>();
    }

    /** Updates the player's money. */
    void Update()
    {
        score.text = "Score: " + scoreNumber;
    }
}
