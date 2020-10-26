using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyBehaviour : MonoBehaviour
{

    public static int moneyValue;
    Text money;
    // Start is called before the first frame update
    void Start()
    {
        moneyValue = 0;
        money = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "Money: " + moneyValue;
    }
}
