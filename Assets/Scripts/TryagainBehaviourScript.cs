/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Load scenes with button press.
*
* Last modified      : 20/10/25
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201003    David Gasinec        Created script. 
*201025    David Gasinec        Updated documentation.
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/** Button click functionality. */
public class TryagainBehaviourScript : MonoBehaviour
{

    /** Makes the button change scenes. */
    public void OnTryAgainButtonPressed()
    {
        Debug.Log("The play again button has been pressed. Going back to main menu.");
        SceneManager.LoadScene("GameLevelScreen");
    }
}
