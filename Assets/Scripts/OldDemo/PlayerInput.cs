using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action<int> onPressSpaceBar;
    private int spacebarCounter = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacebarCounter++;

            onPressSpaceBar?.Invoke(spacebarCounter);
        }
    }

    private void SpacebarPressed()
    {
       
    }
}
