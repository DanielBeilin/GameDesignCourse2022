using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_interact_zone_red : MonoBehaviour
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
        GameObject bloom = GameObject.Find("Bloom01");
        if (other.gameObject == player)
        {
            other.GetComponent<player_triggers>().interactRedZone();
            bloom.SetActive(false);
        }
    }


}
