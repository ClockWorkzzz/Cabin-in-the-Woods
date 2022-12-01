using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
        public GameObject optionsMenu;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Debug.Log("Pressed left click.");
        }

        if (Input.GetMouseButton(1))
        {
            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
            Debug.Log("Pressed right click.");
        }

        if (Input.GetMouseButton(2))
        {

            Debug.Log("Pressed middle click.");
        }
    }
}