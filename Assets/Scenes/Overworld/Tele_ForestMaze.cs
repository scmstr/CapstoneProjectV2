using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tele_ForestMaze : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}
