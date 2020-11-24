using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testInput : MonoBehaviour
{

    public int ANNA;
    // Start is called before the first frame update
    void Start()
    {
        ArduinoInputManagerString.instance.OnClick_1 += Click_01;
        ArduinoInputManagerString.instance.OnClick_2 += Click_02;
        ArduinoInputManagerString.instance.OnClick_3 += Click_03;
        ArduinoInputManagerString.instance.OnClick_4 += Click_04;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Click_01()
    {
        Debug.Log("CHAM _111");
    }
    private void Click_02()
    {   
        Debug.Log("CHAM _222");
    }
    private void Click_03()
    {
        Debug.Log("CHAM _3333");
    }
    private void Click_04()
    {
        Debug.Log("CHAM _4444");
    }
   

}
