using UnityEngine;
using System.Collections.Generic;

public class NoteContainer : MonoBehaviour {

    private List<Note> noteList;

    private void Start() {
        noteList = new List<Note>();
    }

    public void AddNote(Note note) {
        noteList.Add(note);
        print(noteList.Count.ToString());
    }

    public List<Note> SendNoteList() {
        return noteList;
    }
}
