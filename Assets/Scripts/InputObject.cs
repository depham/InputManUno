using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeInput
{
    number_00,
    number_01,
    number_02,
    number_03,
    number_04,
    number_05,
    number_06,
    number_07,
    number_08,
    number_09,
    character_Q,
    character_W,
    character_A,
    character_S,
    character_D,
    character_Z,
    character_X,
    character_ESC
}
public class InputObject
{
    public string nameInput;
    public string conectInputArduino;
    public TypeInput typeInput;
}
