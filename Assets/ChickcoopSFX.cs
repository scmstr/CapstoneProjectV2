using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChickcoopSFX : MonoBehaviour
{
    private float _lastSoundTime = 0;
    private float _randomTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        _lastSoundTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        PlayChickenSFX();
    }


    [Header("Wwise Events")]
    public AK.Wwise.Event chickenCoopSound;

    public void PlayChickenSFX()
    {
        if (IsTime())
        {
            chickenCoopSound.Post(gameObject);
        }
    }

    public float MakeRandom()
    {
        System.Random random = new System.Random();
        return random.Next(0,20);
    }

    public bool IsTime()
    {
        if ((Time.time - _lastSoundTime) > _randomTime) //play the sound
        {
            _randomTime = MakeRandom();
            _lastSoundTime = Time.time;
            return true;
        }
        else //do not play the sound
        {
            return false;
        }
    }





}