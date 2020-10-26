using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogFoodBowlScript : MonoBehaviour
{
    public AudioSource dogbark;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy2" || other.gameObject.tag == "Enemy1")
        {
            dogbark.Play();
            Debug.Log("Collsion Occured!");
        }

    }
}
