using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherAllInteractablesScript : MonoBehaviour
{

    public GameObject interactionBlock;

    void OnEnable()
    {
        BlockInteraction blockInteraction = interactionBlock.GetComponent<BlockInteraction>();

        blockInteraction.GatherAllInteractables();
    }
}
