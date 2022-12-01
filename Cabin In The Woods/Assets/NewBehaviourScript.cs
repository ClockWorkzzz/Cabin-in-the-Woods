using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            EventSystem.current.SetSelectedGameObject(this.gameObject);
 
        if (Input.GetMouseButtonDown(1))
            EventSystem.current.SetSelectedGameObject(this.gameObject);

        if(Input.GetMouseButtonDown(2))
            EventSystem.current.SetSelectedGameObject(this.gameObject);
    }


}
