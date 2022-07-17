using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurt_player : MonoBehaviour
{
    bool alreadyAttacked;

    public GameObject player;

    private void Awake()
    {
        player = GameObject.Find("PlayerCapsule");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered trigger");
        if (other.gameObject.tag == "Player")
        {
            if (!alreadyAttacked)
            {
                alreadyAttacked = true;
                Debug.Log("hit player");
                player_triggers player_triggers = player.GetComponent<player_triggers>();

                player_triggers.get_hit();
                Invoke(nameof(ResetAttack), 2);

            }
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

}
