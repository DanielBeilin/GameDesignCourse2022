using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_interact_zone_door : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        GameObject player = GameObject.Find("PlayerCapsule");
        GameObject mainDoorLeft = GameObject.FindGameObjectWithTag("maindoor_left");
        GameObject mainDoorRight = GameObject.FindGameObjectWithTag("maindoor_right");

        if (other.gameObject == player)
        {
            Debug.Log(other.GetComponent<player_triggers>().objectiveComplete());

            if (mainDoorLeft.transform.rotation.eulerAngles.y == 270f && 
                mainDoorRight.transform.rotation.eulerAngles.y == 270f && 
                !other.GetComponent<player_triggers>().objectiveComplete())
            {
                // close door
                mainDoorLeft.transform.Rotate(0, -90f, 0);
                mainDoorRight.transform.Rotate(0, 90f, 0);

            }
            else if (mainDoorLeft.transform.rotation.eulerAngles.y == 180f &&
                     mainDoorRight.transform.rotation.eulerAngles.y == 0f && 
                     other.GetComponent<player_triggers>().objectiveComplete())
            {
                //open
                mainDoorLeft.transform.Rotate(0, 90f, 0);
                mainDoorRight.transform.Rotate(0, -90f, 0);

            }
        }
    }
}

