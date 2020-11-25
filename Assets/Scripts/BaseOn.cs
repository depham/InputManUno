using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseOnObject : ScriptableObject
{
    
}
public abstract class BaseOn<T> : BaseOnObject where T : class
{
    [SerializeField]
    private List<T> inputs;
}
