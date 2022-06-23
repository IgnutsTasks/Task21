using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Input : MonoBehaviour
{
    private TMP_InputField _text;

    private void Awake()
    {
        _text = GetComponent<TMP_InputField>();
    }

    public void AddCharacter(string sign)
    {
        _text.text += sign;
    }

    public void RemoveLastCharacter()
    {
        string value = _text.text;
        string res = "";
        for (int i = 0; i < value.Length - 1; i++) res += value[i].ToString();
        
        _text.text = res;
    }

    public void EnterTask()
    {
        
    }
}
