using UnityEngine;
using UnityEngine.AI;

public class ZombieA : MonoBehaviour
{
    public float attackDistance = 3f;      // дистанция удара
    public float damage = 10f;             // урон
    public float attackCooldown = 1.5f;    // пауза между ударами

    private Transform player;
    private NavMeshAgent agent;
    private float lastAttackTime;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        agent.stoppingDistance = attackDistance; // чтобы не подходил вплотную
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        // Если далеко — идём к игроку
        if (distance > attackDistance)
        {
            agent.SetDestination(player.position);
        }
        // Если близко — атакуем
        else
        {
            agent.ResetPath();

            if (Time.time > lastAttackTime + attackCooldown)
            {
                Health ph = player.GetComponent<Health>();

                if (ph != null)
                {
                    ph.TakeDamage(damage);
                }

                lastAttackTime = Time.time;
            }
        }
    }
}

