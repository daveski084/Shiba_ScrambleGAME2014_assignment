using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPBehaviour : MonoBehaviour
{

    public static int hitPoints;
    Text HP;
    
    void Start()
    {
        hitPoints = 100;
        HP = GetComponent<Text>();
    }

    
    void Update()
    {
        HP.text = "HP: " + hitPoints;

        if(hitPoints <= 0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
