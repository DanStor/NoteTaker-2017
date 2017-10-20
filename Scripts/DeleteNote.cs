using UnityEngine;
using UnityEngine.UI;

public class DeleteNote : MonoBehaviour {

    private NoteController nCtrl; 

    void Awake()
	{
        nCtrl = FindObjectOfType<NoteController>();
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ButtonPressed);
    }

    private void ButtonPressed(){
        Debug.Log("Delete button pressed");
		nCtrl.DeleteNoSave();
    }

}
