using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Path : MonoBehaviour
{
    public GameObject goToLocation;
    public GameObject leaveLocation;

    public AudioSource audioData;

    void OnMouseDown()
    {
        if (audioData != null)
        { 
            audioData.Play(0);
        }
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        goToLocation.SetActive(true);
        leaveLocation.SetActive(false);
    }

}

