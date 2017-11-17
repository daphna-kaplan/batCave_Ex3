using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BatCave;
using Infra.Gameplay.UI;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Bat Controller/Keyboard")]
public class BatKeyboardController : BatController
{
    override public bool WantsToFlyUp()
    {
        // Handle keyboard input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return true;
        }
        else if (!Input.GetKeyDown(KeyCode.Space))
        {

            return false;
        }
        return false;
    }
}
