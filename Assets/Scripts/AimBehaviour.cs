/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Makes the crosshair follow mouse position and fires projectiles.
*
* Last modified      : 20/10/25
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201023    David Gasinec        Created script. 
*201025    David Gasinec        Updated documentation.
*
|**********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Controlls the crosshair so it follows the mouse and slows down button clicks. */
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


    /** Makes the cursor hidden from the main camera */
    void Start()
    {
        Cursor.visible = false;
    }

    /** Unlocks the mouse input. */
    void UnlockInput()
    {
        mouseLock = false;
    }

    /** Locks mouse input. */
    void LockInput()
    {
        mouseLock = true;
        Invoke("UnlockInput", lockTime);
    }

    /** Boolean flag for mouse lock. */
    public bool isMouseLocked()
    {
        return mouseLock;
    }

    /** Update */
    void Update()
    {
        // Get the target to follow the mouse
       mTargetPoint = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
        Input.mousePosition.y, transform.position.z));
        crosshair.transform.position = new Vector2(mTargetPoint.x, mTargetPoint.y);
        Vector3 difference = mTargetPoint - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        /** Get the crosshair to follow mouse position. */
        if (Input.GetMouseButtonDown(0))
        {
            if (isMouseLocked())
            {
                Debug.Log("Not so fast");
            }
            else
            {
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

        /** Fire projectile.*/
        void FireBoneBullet(Vector2 direction, float rotZ)
        {
            GameObject boneBullet = Instantiate(boneBulletPrefab) as GameObject;
            boneBullet.transform.position = player.transform.position;
            boneBullet.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotZ);
            boneBullet.GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }
}
