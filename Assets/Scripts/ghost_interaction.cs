using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        Debug.Log(GameObject.Find("Capsule"));
        if(collision.gameObject == GameObject.Find("Capsule"))
        {
            player_triggers player_triggers = collision.gameObject.transform.parent.GetComponent<player_triggers>();
            player_triggers.captureGhost();
            Destroy(this.gameObject);

        }
    }
}
