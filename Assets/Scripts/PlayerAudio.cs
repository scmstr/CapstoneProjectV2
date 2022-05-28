using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    // need to set these to pointers for "starting location", not numbers
    private float _lastKnownX = 220;
    private float _lastKnownZ = 420;

    private bool _skiSoundIsPlaying = false;
    private float _lastSkiTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        _lastSkiTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        PlaySkiSound();

    }


    [Header("Wwise Events")]
    public AK.Wwise.Event playerSkiSound;

    public void PlaySkiSound()
    {
        //figure out if moving and how much

        //if no longer on ground, stop 

        //if on ground
        //if moving
        //if lastfootstepplayed time has passed
        //

        if((gameObject.transform.position.x != _lastKnownX || gameObject.transform.position.z != _lastKnownZ) && !_skiSoundIsPlaying)
        {

            playerSkiSound.Post(gameObject);

            _lastSkiTime = Time.time;
            _skiSoundIsPlaying = true;
            _lastKnownX = gameObject.transform.position.x;
            _lastKnownZ = gameObject.transform.position.z;
        }
        else
        {
            if((Time.time - _lastSkiTime) > 1.3)
            {
                _skiSoundIsPlaying = false;
            }
        }

        //if(Time.realtimeSinceStartup.ToString().EndsWith("5"))
        //{
        //    //AkSoundEngine.PostEvent("playerSkiSound", gameObject);
            
        //}
        

    }


    ////stub - eventually one of a series of checking methods for movement interactions
    //public bool IsFloating()
    //{
    //    return false;
    //}

}


