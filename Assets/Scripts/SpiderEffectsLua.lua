local UnityEngine = CS.UnityEngine

-- Configuration variable
local minMoveSpeed = 0.01

-- Component references
local agent = nil
local animator = nil
local audioSource = nil

function start()
    -- Initialize components
    agent = self:GetComponent("NavMeshAgent")
    animator = self:GetComponent("Animator")
    audioSource = self:GetComponent("AudioSource")
end

function update()
    -- Get the agent's speed (magnitude of velocity)
    local speed = agent.velocity.magnitude
    -- Update the animator's Speed parameter
    animator:SetFloat("Speed", speed)

    -- Play or stop audio based on speed
    if speed > minMoveSpeed then
        if not audioSource.isPlaying then
            audioSource:Play()
        end
    else
        if audioSource.isPlaying then
            audioSource:Stop()
        end
    end
end