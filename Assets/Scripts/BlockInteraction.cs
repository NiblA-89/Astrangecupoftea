using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInteraction : MonoBehaviour
{
    public GameObject SayDialogue;
    public GameObject MenuDialogue;
    public GameObject[] interactables;
    private bool interactablesActive = true;

    void Start()
    {
        GatherAllInteractables();
    }

    public void GatherAllInteractables()
    {
        interactables = GameObject.FindGameObjectsWithTag("interactable");
    }

    void Update()
    {
        if (SayDialogue == null)
        {
            if (GameObject.Find("SayDialog") != null)
            {
                SayDialogue = GameObject.Find("SayDialog");
            }

        }
        else if (SayDialogue != null)
        {
            if (SayDialogue.activeSelf)
            {
                if (interactablesActive == true)
                {
                    DeactivateInteractables();
                }
            }

            if (!SayDialogue.activeSelf)
            {
                if (MenuDialogue != null && MenuDialogue.activeSelf)
                {
                    //do nothin
                }
                else
                {
                    if (interactablesActive == false)
                    {
                        ActivateInteractables();
                    }
                }
            }
        } 

        if (MenuDialogue == null)
        {
            if (GameObject.Find("MenuDialog") != null)
            {
                MenuDialogue = GameObject.Find("MenuDialog");
            }

        }
        else if (MenuDialogue != null)
        {
            if (MenuDialogue.activeSelf)
            {
                if (interactablesActive == true)
                {
                    DeactivateInteractables();
                }
            }

            if (!MenuDialogue.activeSelf)
            {
                if (SayDialogue != null && SayDialogue.activeSelf)
                {
                    //do nothin
                }
                else
                {
                    if (interactablesActive == false)
                    {
                        ActivateInteractables();
                    }
                }
            }
        }
    }

    void DeactivateInteractables()
    {
        for (int i = 0; i < interactables.Length; i++)
        {
            interactables[i].SetActive(false);
        }
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        interactablesActive = false;
    }

    void ActivateInteractables()
    {
        for (int i = 0; i < interactables.Length; i++)
        {
            interactables[i].SetActive(true);
        }
        interactablesActive = true;
    }
}
