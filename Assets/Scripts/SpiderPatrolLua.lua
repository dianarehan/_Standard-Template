local UnityEngine = CS.UnityEngine
local Vector3 = UnityEngine.Vector3

-- Configuration variables
local patrolPoints = {}  -- Table to hold Vector3 positions
local waitTime = 2.0  -- Time to wait at each point
local numPoints = 12  -- Number of patrol points
local range = 2  -- Max absolute value for position

-- Internal state variables
local agent = nil
local waitTimer = 0.0

function start()
    -- Initialize the NavMeshAgent component
    agent = self:GetComponent("NavMeshAgent")
    if agent == nil then
        UnityEngine.Debug.LogError("NavMeshAgent component not found!")
        return
    end

    agent.stoppingDistance = 0.5
    agent.speed = 0.2

    -- Generate patrol points with a center point as reference
    local center = UnityEngine.Vector3(-1.644, -8.600791, 17.1121)

    -- Generate new points
    for i = 1, numPoints do
        local x = center.x + (math.random() * 2 - 1) * range
        local z = center.z + (math.random() * 2 - 1) * range
        local y = center.y
        local point = UnityEngine.Vector3(x, y, z)
        table.insert(patrolPoints, point)
    end

    -- Add the center point as a fallback option
    table.insert(patrolPoints, center)

    -- Debug output to verify points were created
    UnityEngine.Debug.Log("Generated " .. #patrolPoints .. " patrol points")

    -- Start patrolling by going to a random point
    goToRandomPoint()
end

function update()
    -- Safety check for agent
    if agent == nil then return end

    -- Check if we've reached our destination
    if not agent.pathPending and agent.remainingDistance <= agent.stoppingDistance then
        -- We've reached the destination (or close enough)
        waitTimer = waitTimer + UnityEngine.Time.deltaTime

        if waitTimer >= waitTime then
            -- Wait time is over, go to next point
            goToRandomPoint()
            waitTimer = 0.0
        end
    end
end

function goToRandomPoint()
    -- Check if there are any patrol points
    if #patrolPoints == 0 then
        UnityEngine.Debug.LogError("No patrol points available")
        return
    end

    -- Choose a random patrol point
    local randomIndex = math.random(1, #patrolPoints)
    local destination = patrolPoints[randomIndex]

    -- Set the destination and log it
    UnityEngine.Debug.Log("Moving to point " .. randomIndex .. ": " .. tostring(destination))
    agent:SetDestination(destination)
end