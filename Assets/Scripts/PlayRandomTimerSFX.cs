using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomTimerSFX : MonoBehaviour
{
    private float _lastSoundTime = 0;
    private float _randomTime = 0;
    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        _lastSoundTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        PlaySFX();
    }


    [Header("Wwise Event")]
    public AK.Wwise.Event WwiseEvent;
    public void PlaySFX()
    {
        if (IsTime())
        {
            WwiseEvent.Post(gameObject);
        }
    }


    [Header("Time Range (Seconds)")]
    public int MinTime;
    public int MaxTime;

    public bool IsTime()
    {
        if ((Time.time - _lastSoundTime) > _randomTime) //play the sound
        {
            _randomTime = random.Next(MinTime, MaxTime);
            _lastSoundTime = Time.time;
            return true;
        }
        else //do not play the sound
        {
            return false;
        }
    }



}
