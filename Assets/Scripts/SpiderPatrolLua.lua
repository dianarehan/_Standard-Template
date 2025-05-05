local UnityEngine = CS.UnityEngine

-- Configuration variables
local patrolPoints = {}  -- Table to hold Vector3 positions
local waitTime = 2.0  -- Time to wait at each point
local numPoints = 12  -- Number of patrol points
local range = 1 -- Max absolute value for position

-- Internal state variables
local agent = nil
local waitTimer = 0.0

function start()
    -- Initialize the NavMeshAgent component
    agent = self:GetComponent("NavMeshAgent")
    agent.stoppingDistance = 0.5
    agent.speed = 3.5

    -- Generate random patrol points
    for i = 1, numPoints do
        local x = math.random(-range, range)
        local z = math.random(-range, range)
        table.insert(patrolPoints, UnityEngine.Vector3(x, 0, z))
    end

    -- Start patrolling by going to a random point
    goToRandomPoint()
end

function update()
    if not agent.pathPending and agent.remainingDistance <= agent.stoppingDistance then
        waitTimer = waitTimer + UnityEngine.Time.deltaTime
        if waitTimer >= waitTime then
            goToRandomPoint()
            waitTimer = 0.0
        end
    end
end

function goToRandomPoint()
    if #patrolPoints == 0 then return end
    local randomIndex = math.random(1, #patrolPoints)
    agent:SetDestination(patrolPoints[randomIndex])
end
