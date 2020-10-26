/***********************************************************************;
* Project            : Shiba Scramble
*
* Program name       : "PlayButtonBehaviourScript.cs"
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Load scenes with button press.
*
* Last modified      : 20/10/03
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201003    David Gasinec        Created script. 
*
|**********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject boneBulletPrefab;
    public float speed = 30.0f;
    public GameObject crosshair;
    public AudioSource shootingSoundSource;
    public float lockTime = 0.1f;

    private Vector3 mTargetPoint;
    private bool mouseLock;
    
    
 
    void Start()
    {
        Cursor.visible = false;
    }

    void UnlockInput()
    {
        mouseLock = false;
    }

    void LockInput()
    {
        mouseLock = true;
        Invoke("UnlockInput", lockTime);
    }

    public bool isMouseLocked()
    {
        return mouseLock;
    }


    void Update()
    {
        // Get the target to follow the mouse
       mTargetPoint = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
        Input.mousePosition.y, transform.position.z));
        crosshair.transform.position = new Vector2(mTargetPoint.x, mTargetPoint.y);
        Vector3 difference = mTargetPoint - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (Input.GetMouseButtonDown(0))
        {
            if (isMouseLocked())
            {
                Debug.Log("Not so fast");
            }
            else
            {
                // StartCoroutine(SlowMouseDown());
                //Fire projectile
                shootingSoundSource.Play();
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;
                // Normalize separates the direction from the magnitude of the vector so speed is constant.
                direction.Normalize();
                FireBoneBullet(direction, rotationZ);
                LockInput();
            }
        }


        void FireBoneBullet(Vector2 direction, float rotZ)
        {
            GameObject boneBullet = Instantiate(boneBulletPrefab) as GameObject;
            boneBullet.transform.position = player.transform.position;
            boneBullet.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotZ);
            boneBullet.GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }
}
