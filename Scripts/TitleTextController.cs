using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleTextController : MonoBehaviour
{
    public void FillForm(string title) {
        GetComponentInChildren<InputField>().text = title;
    }
}
