using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    [SerializeField] private float minIntensity = 0.5f;
    [SerializeField] private float maxIntensity = 1.5f;
    [SerializeField] private float flickerSpeed = 0.1f;
    [SerializeField] private float minInterval = 4f;
    [SerializeField] private float maxInterval = 8f;
    [SerializeField] private AudioClip flickerSound;

    private float nextFlickerTime = 0f;
    private float flickerEndTime = 0f;
    private bool isFlickering = false;
    private Light flickeringLight;
    private float flickerDuration = 0.7f;
    private AudioSource audioSource;

    void Start()
    {
        flickeringLight = GetComponent<Light>();
        flickeringLight.intensity = maxIntensity;
        nextFlickerTime = Time.time + Random.Range(minInterval, maxInterval);
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float currentTime = Time.time;

        if (!isFlickering && currentTime >= nextFlickerTime)
        {
            isFlickering = true;
            flickerDuration = Random.Range(0.1f, 1.0f);
            flickerEndTime = currentTime + flickerDuration;
        }

        if (isFlickering)
        {
            if (currentTime < flickerEndTime)
            {
                flickeringLight.intensity = Random.Range(minIntensity, maxIntensity);
                audioSource.PlayOneShot(flickerSound);
            }
            else
            {
                if(audioSource.isPlaying)
                    audioSource.Stop();
                isFlickering = false;
                flickeringLight.intensity = maxIntensity;
                nextFlickerTime = currentTime + Random.Range(minInterval, maxInterval);
            }
        }
    }
}