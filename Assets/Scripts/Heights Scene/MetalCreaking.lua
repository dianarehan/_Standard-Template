local CS = CS
local UnityEngine = CS.UnityEngine
local Vector3 = UnityEngine.Vector3
local Time = UnityEngine.Time
local Random = UnityEngine.Random

local isPlayerOnBoard = false
local audioSource = nil
local creakTimer = 0
local nextCreakTime = 0

function awake()
    audioSource = gameObject:GetComponent(typeof(UnityEngine.AudioSource))
    if not audioSource then
    end
end

function on_trigger_enter(other)
    if other.gameObject.tag == "MainCamera" then
        isPlayerOnBoard = true
        schedule_next_creak()
    end
end

function on_trigger_exit(other)
    if other.gameObject.tag == "MainCamera" then
        isPlayerOnBoard = false
    end
end

function schedule_next_creak()
    nextCreakTime = Time.time + Random.Range(5.0, 8.0)
end

function update()
    if isPlayerOnBoard and Time.time >= nextCreakTime then
            local selectedClip = Random.Range(0, 2) == 0 and metalCreakClip1 or metalCreakClip2
            if selectedClip ~= nil then
                audioSource:PlayOneShot(selectedClip)
                print(" sound played")
            end
        schedule_next_creak()
    end
end