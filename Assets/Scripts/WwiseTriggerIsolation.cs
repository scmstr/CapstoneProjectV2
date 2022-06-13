using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseTriggerIsolation : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    [Header("Wwise Event on Trigger Enter")]
    public AK.Wwise.Event WwiseEvent;


    public void OnTriggerEnter(Collider other)
    {
            WwiseEvent.Post(gameObject);
    }

    [Header("Wwise Event on TriggerExit")]
    public AK.Wwise.Event WwiseEvent2;

    public void OnTriggerExit(Collider other)
    {
        WwiseEvent2.Post(gameObject);
    }
}
