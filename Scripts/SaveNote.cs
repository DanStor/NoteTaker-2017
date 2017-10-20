using UnityEngine;
using UnityEngine.UI;

public class SaveNote : MonoBehaviour {

    private NoteController nCtrl;

    void Awake()
    {
        nCtrl = FindObjectOfType<NoteController>();
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ButtonPressed);
    }

    private void ButtonPressed(){
        print("Save button pressed");
        nCtrl.SaveNote();
    }
}
