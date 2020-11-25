using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Uduino;
using TMPro;


public class ArduinoInputManagerString : MonoBehaviour
{
    
    public static ArduinoInputManagerString instance;
    public event Action OnClick_1;
    public event Action OnClick_2;
    public event Action OnClick_3;
    public event Action OnClick_4;


    
    private string dataInput;
    private TypeInput typeIP;
    public TextMeshProUGUI UduinoDebugTMP;
    private void Awake()
    {
        instance = this;
        UduinoManager.Instance.OnDataReceived += OnDataReceived;
    }


    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        UduinoDevice myDevice = UduinoManager.Instance.GetBoard("myArduinoName");
        UduinoManager.Instance.Read(myDevice,
            "mySensor");
        
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            OnClick_1?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            OnClick_2?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            OnClick_3?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            OnClick_4?.Invoke();
        }

        Checker();
       
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            dataInput = "0;1;1;1";
            Debug.Log("AAAA");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            dataInput = "1;0;1;1";
            Debug.Log("SSSS");
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            dataInput = "1;1;0;1";
            Debug.Log("ZZZ");
        }
    }

    public void Checker()
    {
        if (dataInput == null)
        {
            dataInput = "1;1;1;1";
        }
        else
        {
            var dataSplited = dataInput.Split(';');
            if (dataSplited[0] == "0")
            {
                OnClick_1?.Invoke();
                Debug.Log("BUTTON_01");
            }
            if (dataSplited[1] == "0")
            {
                OnClick_2?.Invoke();
                Debug.Log("BUTTON_02");
            }
            if (dataSplited[2] == "0")
            {
                OnClick_3?.Invoke();
                Debug.Log("BUTTON_03");
            }
            if (dataSplited[3] == "0")
            {
                OnClick_4?.Invoke();
                Debug.Log("BUTTON_04");
            }
        }

    }
    private string[] dataCached = new[] { "-1", "-1", "-1", "-1", "-1", "-1" };
    public void OnDataReceived(string data, UduinoDevice device)
    {
        Debug.Log("Received");

        UduinoDebugTMP.text = data;

        //var dataSplited = data.Split(';');

        if (dataInput == null)
        {
            dataInput = "1;1;1;1";
        }
        else
        {
            var dataSplited = data.Split(';');
            if(dataSplited[0] != dataCached[0])
            {
                if (dataSplited[0] == "0")
                {
                    OnClick_1?.Invoke();
                    Debug.Log("BUTTON_01");
                }
            }
            
            if(dataSplited[1] != dataCached[1])
            {
                if (dataSplited[1] == "0")
                {
                    OnClick_2?.Invoke();
                    Debug.Log("BUTTON_02");
                }
            }
            

           
        }
    }

   
}

