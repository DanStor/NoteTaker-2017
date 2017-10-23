using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class NoteContainer : MonoBehaviour {

    private List<Note> noteList;

    void Start() {
        noteList = new List<Note>();
    }

    public void AddNote(Note note) {
		noteList.Add(note);
        Debug.Log(noteList.Count.ToString());
		Debug.Log("Note added to noteList");
		DebugCheckItemsInList();
	}

	private void DebugCheckItemsInList() {
		int i = 1;
		foreach (Note noteInList in noteList) {
			Debug.Log("Note number: " + i + ". Title: " + noteInList.GetTitle() + ". Content: " + noteInList.GetContent());
			i++;
		}
	}

	public List<Note> SendNoteList() {
        return noteList;
    }

	public void RemoveNote(Note noteToRemove) {
		noteList.Remove(noteToRemove);
		DebugCheckItemsInList();
	}
}
