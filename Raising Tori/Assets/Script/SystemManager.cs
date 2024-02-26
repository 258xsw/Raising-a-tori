using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemManager : MonoBehaviour
{

    public Toggle original;
    public GameObject scrollViewContent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCheckBox()
    {
        Toggle newToggle = Instantiate(original, scrollViewContent.transform.position, Quaternion.identity, scrollViewContent.transform);
        Debug.Log(newToggle.GetComponent<Toggle>().isOn);
        if (newToggle.GetComponent<Toggle>().isOn) newToggle.GetComponent<Toggle>().isOn = false;

    }
}
