using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BatCave;
using Infra.Gameplay.UI;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Bat Controller/Mouse")]
public class BatMouseController : BatController
{

    private bool flyUp;

    private void OnEnable()
    {
        GameInputCapture.OnTouchDown += OnTouchDown;
        GameInputCapture.OnTouchUp += OnTouchUp;

    }

    private void OnDisable()
    {
        GameInputCapture.OnTouchDown -= OnTouchDown;
        GameInputCapture.OnTouchUp -= OnTouchUp;

    }

    private void OnTouchDown(PointerEventData e)
    {
        flyUp = true;
    }

    private void OnTouchUp(PointerEventData e)
    {
        flyUp = false;
    }


override public bool WantsToFlyUp()
    {
        return flyUp;
    }
}
