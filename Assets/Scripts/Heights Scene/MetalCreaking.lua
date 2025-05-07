local CS = CS
local UnityEngine = CS.UnityEngine
local Vector3 = UnityEngine.Vector3
local Time = UnityEngine.Time

local isPlayerOnBoard = false
local audioSource = nil
local creakTimer = 0
local nextCreakTime = 0
local creakCounter = 0

function awake()
    audioSource = gameObject:GetComponent(typeof(UnityEngine.AudioSource))
    if not audioSource then
        print("AudioSource not found!")
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
    if creakCounter % 2 == 0 then
        nextCreakTime = Time.time + 5.0
    else
        nextCreakTime = Time.time + 3.0
    end
    creakCounter = creakCounter + 1
end

function update()
    if isPlayerOnBoard and Time.time >= nextCreakTime then
        if audioSource and metalCreakClip then
            if not audioSource.isPlaying then
                audioSource:PlayOneShot(metalCreakClip)
                print("Sound played")
            end
        end
    
        schedule_next_creak()
    end
end