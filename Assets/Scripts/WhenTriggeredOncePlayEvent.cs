using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenTriggeredOncePlayEvent : MonoBehaviour
{
    public bool hasBeenPlayed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    [Header("Wwise Event To Play")]
    public AK.Wwise.Event WwiseEvent;


    public void OnTriggerEnter(Collider other)
    {
        if (!hasBeenPlayed)
        {
            WwiseEvent.Post(gameObject);
            hasBeenPlayed = true;
        }
    }












}
