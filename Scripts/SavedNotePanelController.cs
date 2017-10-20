using UnityEngine;
using System.Collections.Generic;

public class SavedNotePanelController : MonoBehaviour {

	private NoteContainer nCont;
	private OpenNote opNo;
	private float yPosVar;

	// Use this for initialization
	void Start () {
		nCont = FindObjectOfType<NoteContainer>();
		opNo = GetComponentInChildren<OpenNote>();
		//yPosVar = 
		Populate ();
	}

	private void Populate () {
		//TODO: Populate saved note panel with saved notes
		List<Note> noteList = nCont.SendNoteList();
		if(noteList.Count <= 0) {
			Destroy(opNo.gameObject);
			return;
		}

		foreach(Note note in noteList) {
			Instantiate(opNo.gameObject,new Vector3(transform.position.x,transform.position.y + yPosVar,transform.position.z),Quaternion.identity);
			opNo.GetTitle(note.GetTitle());
		}
	}

}
