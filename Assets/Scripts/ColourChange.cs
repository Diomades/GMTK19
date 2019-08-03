using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColourSetting { none, blue, red }

public class ColourChange : MonoBehaviour
{
    public Color worldRed;
    public Color worldBlue;
    public Light worldLight;
    public Camera playerCamera;

    private ColourSetting curColour = ColourSetting.none;
    private ColourSetting nextColour = ColourSetting.none;

    public Animator eyelids;
    public Animator glasses;
    public bool movedGlasses = false;

    void Update()
    {
        //Swap colours when Tab is pressed
        if (Input.GetKeyUp("tab"))
        {
            if (curColour == ColourSetting.red)
            {
                StartMove(ColourSetting.blue);
            }
            else if (curColour == ColourSetting.blue || curColour == ColourSetting.none)
            {
                StartMove(ColourSetting.red);
            }
        }
        //DEBUG ONLY
        //Swap away from lenses for testing purposes
        if (Input.GetKeyUp("q"))
        {
            if (curColour != ColourSetting.none)
            {
                StartMove(ColourSetting.none);
            }
        }
    }

    //Start the blink animations and set the next colour to swap to
    private void StartMove(ColourSetting c)
    {
        eyelids.SetTrigger("Blink");
        movedGlasses = !movedGlasses;
        glasses.SetBool("movedGlasses", movedGlasses);
        nextColour = c;
    }

    //Called by the blink animation at the point the eyes are entirely closed as to transition to the next colour
    public void SwapColour()
    {
        switch (nextColour)
        {
            case ColourSetting.red:
                playerCamera.backgroundColor = worldRed;
                RenderSettings.ambientLight = worldRed;
                worldLight.color = worldRed;
                break;
            case ColourSetting.blue:
                playerCamera.backgroundColor = worldBlue;
                RenderSettings.ambientLight = worldBlue;
                worldLight.color = worldBlue;
                break;
            case ColourSetting.none:
                playerCamera.backgroundColor = Color.white;
                RenderSettings.ambientLight = Color.white;
                worldLight.color = Color.white;
                break;
        }

        curColour = nextColour;
        nextColour = ColourSetting.none;
    }
}
