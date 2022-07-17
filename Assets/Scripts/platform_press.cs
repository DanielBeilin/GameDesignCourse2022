using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_press : MonoBehaviour
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
        Debug.Log("tag:");
        Debug.Log(gameObject.tag);
        Debug.Log("collider");
        Debug.Log(other.gameObject);
        GameObject player = GameObject.Find("PlayerCapsule");
        if (other.gameObject == player)
        {
            if(gameObject.tag == "Untagged")
            {
                GetComponentInChildren<ParticleSystem>().Stop();
                other.GetComponent<player_triggers>().step_on_platform();
                gameObject.tag = "Finish";
            }
        }
    }

}
