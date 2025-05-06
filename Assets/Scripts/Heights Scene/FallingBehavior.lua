local CS = CS
local UnityEngine = CS.UnityEngine
local Vector3 = UnityEngine.Vector3
local Time = UnityEngine.Time
local coroutine = coroutine

local isFalling = false
local fallDistance = 20
local fallDuration = 2


function awake()
    if xrOrigin == nil then
        print("xrOrigin not assigned in Lua!")
    end

    if gameObject == nil then
        print("gameObject is nil!")
    else
        triggerObject = gameObject:GetComponent(typeof(UnityEngine.Collider))
        print("Trigger object:", triggerObject)
    end
end

function on_trigger_enter(other)
    if not isFalling and other.gameObject.tag == "MainCamera" then
        isFalling = true
        elapsed = 0
        startPos = xrOrigin.transform.position
        endPos = startPos + Vector3.down * fallDistance
    end
end

function update()
    if isFalling then
        if elapsed < fallDuration then
            local t = elapsed / fallDuration
            xrOrigin.transform.position = Vector3.Lerp(startPos, endPos, t)
            elapsed = elapsed + Time.deltaTime
        else
            xrOrigin.transform.position = Vector3(0, 1, 0)
            isFalling = false
        end
    end
end