using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_Patrol : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5;
    int currentWaypoint;
    private bool flag = true;
    Vector3 target, moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = waypoints[currentWaypoint].position;
        moveDirection = target - transform.position;
        if(moveDirection.magnitude < 1 && flag)
        {
            currentWaypoint = ++currentWaypoint % waypoints.Length;
            StartCoroutine(Stay());
        }
        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
    }

    private IEnumerator Stay()
    {
        flag = false;
        yield return new WaitForSeconds(2);
        flag = true; 
    }
}
