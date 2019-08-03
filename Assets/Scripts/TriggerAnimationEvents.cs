using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationEvents : MonoBehaviour
{
    public void TwiggerSwapColour()
    {
        GameObject.Find("Player").GetComponent<ColourChange>().SwapColour();
    }
}
