using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpacebarText : MonoBehaviour
{
    [SerializeField] TMP_Text spacebarTextObject;
    [SerializeField] PlayerInput input;

    private void OnEnable()
    {
        input.onPressSpaceBar += updateTextWithValue;
    }

    private void OnDisable()
    {
        input.onPressSpaceBar -= updateTextWithValue;
    }

    private void updateTextWithValue(int incomingValue)
    {
        spacebarTextObject.text = $"Spacebar pressed: {incomingValue}";
    }
}
