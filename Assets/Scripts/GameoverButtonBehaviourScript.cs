﻿/***********************************************************************;
* Project           : Shiba Scramble
*
* Program name      : "GameoverButtonBehaviourScript.cs"
*
* Author            : David Gasinec
* 
* Student Number    : 101187910
*
* Date created      : 20/10/03
*
* Description       : Load scenes with button press.
*
* Last modified     : 20/10/03
*
* Revision History  :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201003    David Gasinec        Created script. 
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverButtonBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGameOverButtonPressed()
    {
        Debug.Log("Going to game over screen.");
        SceneManager.LoadScene("GameOverScreen");
    }
}