using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnstartButtonPressed()
    {
        Debug.Log("Start Button Pressed.");
        SceneManager.LoadScene("MainMenu");
    }
}
