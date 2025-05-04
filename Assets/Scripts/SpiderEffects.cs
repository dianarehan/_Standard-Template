using UnityEngine;
using UnityEngine.AI;

public class SpiderEffects : MonoBehaviour
{    
    [SerializeField] private float minMoveSpeed = 0.01f;
    private NavMeshAgent agent;
    private Animator animator;
    private AudioSource audioSource;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float speed = agent.velocity.magnitude;
        animator.SetFloat("Speed", speed);

        if (speed > minMoveSpeed)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
}