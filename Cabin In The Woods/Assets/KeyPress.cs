using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KeyPress : MonoBehaviour 
{
    public string _key;
    public Button _button;

    void Awake()
    {
        _button = GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyDown(_key))
        {

            EventSystem.current.SetSelectedGameObject(this.gameObject);

        }
    }
}
