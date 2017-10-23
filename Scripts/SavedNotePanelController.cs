using UnityEngine;
using System.Collections.Generic;

public class SavedNotePanelController : MonoBehaviour {

	private NoteContainer nCont;
    private OpenNoteButtonController opNo;
    public float notePanelSize;

	// Use this for initialization
	void Start () {
		nCont = FindObjectOfType<NoteContainer>();
        opNo = FindObjectOfType<OpenNoteButtonController>();
		//yPosVar = 
		Populate ();
	}

    //Populate saved note panel with saved notes
	private void Populate () {
		List<Note> noteList = nCont.SendNoteList();
		
        int k = 0;
		foreach(Note note in noteList) {
            GameObject opNoClone = Instantiate(opNo.gameObject,new Vector3(transform.position.x,transform.position.y - (notePanelSize * k),transform.position.z),Quaternion.identity,transform);
            opNoClone.GetComponent<OpenNoteButtonController>().GetInfo(note.GetTitle());
            ++k;
		}

        Destroy(opNo.gameObject);
	}
}
