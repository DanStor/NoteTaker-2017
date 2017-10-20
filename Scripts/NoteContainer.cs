using UnityEngine;
using System.Collections.Generic;

public class NoteContainer : MonoBehaviour {

    private List<Note> noteList;

    void Start() {
        noteList = new List<Note>();
    }

    public void AddNote(Note note) {
        noteList.Add(note);
        print(noteList.Count.ToString());
        Debug.Log("Note added to noteList");

        int i = 1;
        foreach (Note noteInList in noteList)
        {
            Debug.Log("Note number: " + i + " title: " + noteInList.GetTitle() + " content: " + noteInList.GetContent());
            i++;
        }
    }

    public List<Note> SendNoteList() {
        return noteList;
    }

    public void RemoveNote(Note noteToRemove) {
        noteList.Remove(noteToRemove);
    }
}
