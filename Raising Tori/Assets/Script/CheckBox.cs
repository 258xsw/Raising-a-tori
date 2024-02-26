using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckBox : MonoBehaviour
{
    // Start is called before the first frame update
    Toggle toggle;
    LevelManager levelManager;
    public GameObject eventSystem;


    //public GameObject text;
    //public TextMeshProUGUI textMeshPro;
    void Start()
    {
        
        toggle = this.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleChanged);
        
        levelManager = eventSystem.GetComponent<LevelManager>();
        
    }



    void OnToggleChanged(bool isOn)
    {
        TextMeshProUGUI textMeshPro = this.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        if (isOn)
        {
            textMeshPro.fontStyle = FontStyles.Strikethrough;
            LevelManager.degreeOfGrowth++;
        }
        else
        {
            textMeshPro.fontStyle &= ~FontStyles.Strikethrough;
            LevelManager.degreeOfGrowth--;
        }
        levelManager.SliderController();
    }
}
