local UnityEngine = CS.UnityEngine
local Vector3 = UnityEngine.Vector3


-- Configuration variables
local patrolPoints = {}  -- Table to hold Vector3 positions
local waitTime = 2.0  -- Time to wait at each point
local numPoints = 12  -- Number of patrol points
local range = 15  -- Max absolute value for position

-- Internal state variables
local agent = nil
local waitTimer = 0.0

function start()
    -- Initialize the NavMeshAgent component
    agent = self:GetComponent("NavMeshAgent")
    agent.stoppingDistance = 0.5
    agent.speed = 3.5

    local center = UnityEngine.Vector3(-1.644, -9.367, 17.037)

    for i = 1, numPoints do
        local x = center.x + math.random(-range, range)
        local z = center.z + math.random(-range, range)
        local y = center.y  -- or sample NavMesh height if needed
        table.insert(patrolPoints, UnityEngine.Vector3(x, y, z))
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