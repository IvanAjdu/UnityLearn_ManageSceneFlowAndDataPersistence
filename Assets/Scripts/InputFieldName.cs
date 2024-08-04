using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFieldName : MonoBehaviour
{
    [SerializeField] private string inputTextName;

    public void GetFromInputField(string inputName)
    {
        inputTextName = inputName;
        Debug.Log("Input : " + inputName);
        Debug.Log("Name : " + inputTextName);
    }
}
