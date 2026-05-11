using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLocation : MonoBehaviour
{
    public GameObject[] activeLocations;

    public void ActivateLocation()
    {
        activeLocations = GameObject.FindGameObjectsWithTag("location");

        for (int i = 0; i < activeLocations.Length; i++)
        {
            activeLocations[i].SetActive(false);
        }

        this.gameObject.SetActive(true);
    }
}
