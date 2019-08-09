using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationEvents : MonoBehaviour
{
    public void TwiggerSwapColour()
    {
        GameObject.Find("ScriptController").GetComponent<ColourChange>().SwapColour();
    }
}
