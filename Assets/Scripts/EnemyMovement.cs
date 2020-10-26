using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 2.0f;

    private Transform destination;
    private int wayPointIndex = 0;


    void Start()
    {
        destination = Waypoints.waypoints[0];
    }

    void Update()
    {
        Vector2 direction = destination.position - transform.position;
        transform.Translate(direction.normalized * enemySpeed * Time.deltaTime, Space.World);

        if(Vector2.Distance(transform.position, destination.position) <= 1.8f)
        {
            GetNextPoint();
        }
    }

    void GetNextPoint()
    {
        wayPointIndex++;
        destination = Waypoints.waypoints[wayPointIndex];
    }
}
