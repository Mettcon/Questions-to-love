
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class interactionTester : UdonSharpBehaviour
{
    public override void Interact()
    {
        base.Interact();
        gameObject.SetActive(false);
    }
}
