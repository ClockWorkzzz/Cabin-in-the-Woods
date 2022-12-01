using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button : MonoBehaviour 
{
    public string key;


    void Update()
    {
        if(Input.GetKeyDown(key))
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject);
            
        }
    }
}
