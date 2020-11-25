using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerU : Singleton<InputManagerU>
{
    
    public List<testInput> lsInput = new List<testInput>();
    [SerializeField]
    private testInput prefab;

    public void OnAddInput()
    {
        testInput inputs = Instantiate(prefab);
        lsInput.Add(inputs);
        inputs.transform.SetParent(transform);
        inputs.name = "Input_" + lsInput.Count.ToString();
    }   
}

public class InputU
{
    public string name;
    public string connect;
}