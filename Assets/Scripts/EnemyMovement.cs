/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Enemy AI path waypoint movement.
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
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;

/** Gets enemy Ai to follow waypoints stored in the array. */
public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 2.0f;

    private Transform destination;
    private int wayPointIndex = 0;

    /** Initializes destination point with first waypoint. */
    void Start()
    {
        destination = Waypoints.waypoints[0];
    }

    /** Get the enemies to follow waypoints. */
    void Update()
    {
        Vector2 direction = destination.position - transform.position;
        transform.Translate(direction.normalized * enemySpeed * Time.deltaTime, Space.World);

        if(Vector2.Distance(transform.position, destination.position) <= 1.8f)
        {
            GetNextPoint();
        }
    }

    /** Finds the next waypoint. */
    void GetNextPoint()
    {
        wayPointIndex++;
        destination = Waypoints.waypoints[wayPointIndex];
    }
}
