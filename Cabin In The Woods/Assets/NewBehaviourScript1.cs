using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
        public GameObject Menu;
        public GameObject Help;


    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(1))
        
            Menu.gameObject.SetActive(!Menu.gameObject.activeSelf);
        
        if (Input.GetMouseButtonDown(2))
     
            Help.gameObject.SetActive(!Help.gameObject.activeSelf);
        
    }
}