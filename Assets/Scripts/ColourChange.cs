using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorSetting { none, blue, red }

public class ColourChange : MonoBehaviour
{
    public Color worldRed;
    public Color worldBlue;
    private ColorSetting curColor = ColorSetting.red;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("tab"))
        {
            if (curColor == ColorSetting.red)
            {
                RenderSettings.ambientLight = worldBlue;
                curColor = ColorSetting.blue;
            }
            else if (curColor == ColorSetting.blue || curColor == ColorSetting.none)
            {
                RenderSettings.ambientLight = worldRed;
                curColor = ColorSetting.red;
            }
        }
        if (Input.GetKeyUp("q"))
        {
            if (curColor != ColorSetting.none)
            {
                RenderSettings.ambientLight = Color.white;
                curColor = ColorSetting.none;
            }
        }
    }
}
