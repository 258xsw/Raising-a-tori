using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class LevelManager : MonoBehaviour
{
    const int LEVEL_1 = 10;
    Toggle toggle;
    public Slider growthSlider;
    public static int degreeOfGrowth;
    // Start is called before the first frame update
    void Start()
    {
        toggle = this.GetComponent<Toggle>();
        //toggle.onValueChanged.AddListener(OnToggleChanged);
        //growthSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SliderController()
    {
        Debug.Log("haha");
        Debug.Log(degreeOfGrowth % LEVEL_1);

       growthSlider.value = (float)degreeOfGrowth % LEVEL_1 * 0.1f;
    }

}
