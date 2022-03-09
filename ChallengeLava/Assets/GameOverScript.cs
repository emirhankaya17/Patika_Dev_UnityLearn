using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Lava")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
