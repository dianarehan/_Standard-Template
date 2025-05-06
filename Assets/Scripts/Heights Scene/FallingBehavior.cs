using UnityEngine;
using System.Collections;

public class FallingBehavior : MonoBehaviour
{
    [SerializeField] private Transform xrOrigin;
    [SerializeField] private float fallDistance = 20f;
    [SerializeField] private float fallDuration = 2f;
    // [SerializeField] private AudioClip fallSound;
    // [SerializeField] private AudioSource audioSource;

    private bool isFalling = false;

    void  OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera") && !isFalling)
        {
            StartCoroutine(FallRoutine());
            Debug.Log("Falling triggered!");
        }

    }

    IEnumerator FallRoutine()
    {
        isFalling = true;

        // if (fallSound && audioSource)
        //     audioSource.PlayOneShot(fallSound);

        Vector3 start = xrOrigin.position;
        Vector3 end = start + Vector3.down * fallDistance;

        float elapsed = 0f;
        while (elapsed < fallDuration)
        {
            float t = elapsed / fallDuration;
            xrOrigin.position = Vector3.Lerp(start, end, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        xrOrigin.position = new Vector3(0f, 1f, 0f); 
        isFalling = false;
    }
}