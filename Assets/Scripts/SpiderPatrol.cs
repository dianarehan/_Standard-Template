using UnityEngine;
using UnityEngine.AI;

public class SpiderPatrol : MonoBehaviour
{
    [SerializeField] private float patrolRadius = 10f;
    [SerializeField] private float waitTime = 2f;
    private NavMeshAgent agent;
    private Vector3 startPosition;
    private float waitTimer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        startPosition = transform.position;
        GoToNewPoint();
    }

    void Update()
    {
        //TODO: avoid spiders move through each other

        if (!agent.pathPending&& agent.remainingDistance <= agent.stoppingDistance)
        {
            waitTimer+= Time.deltaTime;
            if (waitTimer >= waitTime)
            {
                GoToNewPoint();
                waitTimer = 0;
            }
        }
    }

    void GoToNewPoint()
    {
        Vector3 randomDirection = Random.insideUnitSphere * patrolRadius;
        randomDirection += startPosition;

        if (NavMesh.SamplePosition(randomDirection, out NavMeshHit hit, patrolRadius, NavMesh.AllAreas))
            agent.SetDestination(hit.position);
    }
}