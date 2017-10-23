using UnityEngine;
using UnityEngine.UI;

public class NotePanelTextController : MonoBehaviour {

    public void SetText(string titleText) {
        GetComponentInChildren<Text>().text = titleText;
    }
}
