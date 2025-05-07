local CS = CS
local UnityEngine = CS.UnityEngine
local Time = UnityEngine.Time

local minIntensity = 0.5
local maxIntensity = 7.0
local minInterval = 9.0
local maxInterval = 15.0

local flickeringLight = nil
local audioSource = nil
local nextFlickerTime = 0.0
local flickerEndTime = 0.0
local isFlickering = false
local flickerDuration = 0.7

function calculateValue(base, range, factor)
    return base + range * math.abs(math.sin(Time.time * factor))
end

function awake()
    flickeringLight = gameObject:GetComponent(typeof(UnityEngine.Light))
    audioSource = gameObject:GetComponent(typeof(UnityEngine.AudioSource))

    if flickeringLight then
        flickeringLight.intensity = maxIntensity
    end

    nextFlickerTime = Time.time + calculateValue(minInterval, maxInterval - minInterval, 0.1)
end

function update()
    local currentTime = Time.time

    if not isFlickering and currentTime >= nextFlickerTime then
        isFlickering = true
        flickerDuration = calculateValue(0.1, 0.9, 0.2)
        flickerEndTime = currentTime + flickerDuration
    end

    if isFlickering then
        if currentTime < flickerEndTime then
            if flickeringLight then
                local flickerFactor = math.random(5, 15) * 0.1
                flickeringLight.intensity = calculateValue(minIntensity, maxIntensity - minIntensity, flickerFactor)
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
            nextFlickerTime = currentTime + calculateValue(minInterval, maxInterval - minInterval, 0.1)
        end
    end
end