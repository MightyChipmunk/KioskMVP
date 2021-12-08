using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    public string num;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Convert.ToInt32(num) == 1)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 2)
        {
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 3)
        {
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 4)
        {
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 5)
        {
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 6)
        {
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 7)
        {
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 8)
        {
            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                Add();
            }
        }
        if (Convert.ToInt32(num) == 9)
        {
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                Add();
            }
        }
    }

    public void Add()
    {
        if(QuantityManager.quantity.Length < 2)
            QuantityManager.quantity += num;
    }
}
