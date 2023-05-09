using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
    public void LogHoverEnter(HoverEnterEventArgs args)
    {
        print(gameObject.name + " Hover Enter by: " + args.interactorObject);
    }
    public void LogHoverExit(HoverExitEventArgs args)
    {
        print(gameObject.name + " Hover Exit by: " + args.interactorObject);
    }
    public void LogSelect(SelectEnterEventArgs args)
    {
        print(gameObject.name + " Selected by: " + args.interactorObject);
    }
    public void LogDeselect(SelectExitEventArgs args)
    {
        print(gameObject.name + " Deselected by: " + args.interactorObject);
    }
    public void LogActivate(ActivateEventArgs args)
    {
        print(gameObject.name + " Activated by: " + args.interactorObject);
    }
    public void LogDeactivate(DeactivateEventArgs args)
    {
        print(gameObject.name + " Deactivated by: " + args.interactorObject);
    }
}