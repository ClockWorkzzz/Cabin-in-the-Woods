using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuManager : MonoBehaviour
{
    public GameObject optionsMenu;
   
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
        }
    }
    

}
