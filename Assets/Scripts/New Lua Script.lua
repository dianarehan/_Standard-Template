local UnityEngine = CS.UnityEngine
local ImmerzaSDK = CS.ImmerzaSDK

-- Configuration
local maxDuration = 60.0 -- End the scene after 60 seconds

-- Component references
local agent = nil
local animator = nil
local audioSource = nil
local isPaused = false
local totalTime = 0.0

function awake()
    -- Subscribe to the OnPauseRequested event
    CS.ImmerzaSDK.ImmerzaEvents.OnPauseRequested('+', onPauseRequested)
    -- Subscribe to the OnSceneEnd event
    CS.ImmerzaSDK.ImmerzaEvents.OnSceneEnd('+', onSceneEnd)
end


function start()
    -- Initialize components
    agent = self:GetComponent("NavMeshAgent")
    animator = self:GetComponent("Animator")
    audioSource = self:GetComponent("AudioSource")
end

function update()
    if isPaused then return end

    -- Track total time and end the scene when maxDuration is reached
    totalTime = totalTime + UnityEngine.Time.deltaTime
    if totalTime >= maxDuration then
        CS.ImmerzaSDK.ImmerzaEvents.EndScene() -- Call EndScene directly
    end
end


function OnPauseRequested(shouldPause)
    isPaused = shouldPause
    if shouldPause then
        -- Pause movement, animations, and audio
        if agent then
            agent.isStopped = true
        end
        if animator then
            animator.speed = 0
        end
        if audioSource and audioSource.isPlaying then
            audioSource:Pause()
        end
    else
        -- Resume movement, animations, and audio
        if agent then
            agent.isStopped = false
        end
        if animator then
            animator.speed = 1
        end
        if audioSource then
            audioSource:UnPause()
        end
    end
end

function OnSceneEnd()
    -- Clean up before scene ends
    if agent then
        agent.isStopped = true
    end
    if animator then
        animator.speed = 0
    end
    if audioSource and audioSource.isPlaying then
        audioSource:Stop()
    end
    -- Log for debugging
    UnityEngine.Debug.Log("Scene ending: Spider cleanup complete")
end