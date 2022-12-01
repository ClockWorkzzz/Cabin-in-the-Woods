using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
        public GameObject Menu;
        public GameObject Help;


    void FixedUpdate()
    {

        if (Input.GetMouseButton(1))
        {
            Menu.gameObject.SetActive(!Menu.gameObject.activeSelf);
         
        }

        if (Input.GetMouseButton(2))
        {

            Help.gameObject.SetActive(!Help.gameObject.activeSelf);
        }
    }
}