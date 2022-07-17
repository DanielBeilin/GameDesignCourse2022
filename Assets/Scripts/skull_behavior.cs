using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skull_behavior : MonoBehaviour
{
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int layerMask = 1 << 8;

        ParticleSystem particle = GetComponentInChildren<ParticleSystem>();

        if (particle != null)
        {
            particle.Play();
        }

        RaycastHit hit;

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out hit, 10, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("hit player");
            Debug.Log(hit.collider);
            hit.collider.GetComponent<player_triggers>().get_hit();
            Destroy(gameObject);
        }

    }

}
