using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ContentTextController : MonoBehaviour
{
    public void FillForm(string title) {
        GetComponentInChildren<InputField>().text = title;
    }
}
