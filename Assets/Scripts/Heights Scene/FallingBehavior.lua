local CS = CS
local UnityEngine = CS.UnityEngine
local Vector3 = UnityEngine.Vector3
local Time = UnityEngine.Time

local isFalling = false
local fallDistance = 20
local fallDuration = 2
local hapticComponent = nil
local audioSource = nil

function awake()
    if xrOrigin == nil then
        print("xrOrigin not assigned in Lua!")
    end
    audioSource = xrOrigin:GetComponent(typeof(UnityEngine.AudioSource))
    print("Audio source:", audioSource)

    if gameObject == nil then
        print("gameObject is nil!")
    else
        triggerObject = gameObject:GetComponent(typeof(UnityEngine.Collider))
        print("Trigger object:", triggerObject)
    end
    if hapticPlayer == nil then
        print("HapticImpulsePlayer not found on xrOrigin!")
    end
    hapticComponent = hapticPlayer:GetComponent(typeof(CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulsePlayer))
end

function on_trigger_enter(other)
    if not isFalling and other.gameObject.tag == "MainCamera" then
        isFalling = true
        elapsed = 0
        startPos = xrOrigin.transform.position
        endPos = startPos + Vector3.down * fallDistance

        if hapticPlayer ~= nil then
            local var = hapticComponent:SendHapticImpulse(0.5, 0.2) 
            print("Haptic impulse sent!", var)
        end
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
            if hapticPlayer ~= nil then
                hapticComponent:SendHapticImpulse(0.7, 0.3)
            end
            if fallingClip ~= nil then
                audioSource:PlayOneShot(fallingClip)
            end
        end
    end
end