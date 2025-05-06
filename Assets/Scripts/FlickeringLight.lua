local CS = CS
local UnityEngine = CS.UnityEngine
local Random = UnityEngine.Random
local Time = UnityEngine.Time

local minIntensity = 0.5
local maxIntensity = 1.5
local minInterval = 4.0
local maxInterval = 8.0

local flickeringLight = nil
local audioSource = nil
local nextFlickerTime = 0.0
local flickerEndTime = 0.0
local isFlickering = false
local flickerDuration = 0.7

function awake()
    flickeringLight = gameObject:GetComponent(typeof(UnityEngine.Light))
    audioSource = gameObject:GetComponent(typeof(UnityEngine.AudioSource))

    if flickeringLight then
        flickeringLight.intensity = maxIntensity
    end

    nextFlickerTime = Time.time + Random.Range(minInterval, maxInterval)
end

function update()
    local currentTime = Time.time

    if not isFlickering and currentTime >= nextFlickerTime then
        isFlickering = true
        flickerDuration = Random.Range(0.1, 1.0)
        flickerEndTime = currentTime + flickerDuration
    end

    if isFlickering then
        if currentTime < flickerEndTime then
            if flickeringLight then
                flickeringLight.intensity = Random.Range(minIntensity, maxIntensity)
            end
            if audioSource and flickerSound then
                audioSource:PlayOneShot(flickerSound)
            end
        else
            if audioSource and audioSource.isPlaying then
                audioSource:Stop()
            end
            isFlickering = false
            if flickeringLight then
                flickeringLight.intensity = maxIntensity
            end
            nextFlickerTime = currentTime + Random.Range(minInterval, maxInterval)
        end
    end
end
