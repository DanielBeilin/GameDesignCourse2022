using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_interact_zone_end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem particle = GetComponentInChildren<ParticleSystem>();

        if (particle != null)
        {
            particle.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem particle = GetComponentInChildren<ParticleSystem>();
        
        if (particle != null)
        {
            if (GameObject.Find("PlayerCapsule").GetComponent<player_triggers>().objectiveComplete() && 
                !particle.isPlaying)
            {
                particle.Play();   
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {

        GameObject player = GameObject.Find("PlayerCapsule");
        if (other.gameObject == player)
        {
            if (other.GetComponent<player_triggers>().objectiveComplete())
            {
                SceneManager.LoadScene("Scenes/OnTheRun");
            }
        }
    }

}
