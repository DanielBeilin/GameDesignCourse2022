using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class reaper_controller : MonoBehaviour
{
    public NavMeshAgent agent;
    GameObject player;

    public float timeBetweenAttacks;
    bool alreadyAttacked;

    LayerMask whatIsPlayer;

    public float attackRange;
    private bool playerInAttackRange;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.Find("PlayerCapsule");
    }
    // Update is called once per frame
    void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        if (playerInAttackRange) attackPlayer();
        agent.SetDestination(player.transform.position);
    }

    public void attackPlayer()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player.transform);

        if (!alreadyAttacked)
        {
            animator.SetInteger("Attack", Random.Range(1, 3));
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
