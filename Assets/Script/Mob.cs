using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{

    [SerializeField] private float heal;
    
    public List<Transform> patrolPoints;
    public PlayerController player;
    public UnityEngine.AI.NavMeshAgent Agent;
    public float DetectDistance;
    public float AttackDistance;
    
    public int i = 0;

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < DetectDistance)
        {
            Agent.SetDestination(player.transform.position);
            if (Vector3.Distance(transform.position, player.transform.position) < AttackDistance)
            {
                player.GetComponent<PlayerHeal>().TakeDamage(1);
            }
        }
        else
        {
            if (!Agent.pathPending && Agent.remainingDistance < Agent.stoppingDistance)
            {
                Agent.SetDestination(patrolPoints[i].position);
                i += 1;
                if (i >= patrolPoints.Count)
                {
                    i = 0;
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            heal--;
            if (heal <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
