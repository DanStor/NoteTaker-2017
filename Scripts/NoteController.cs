using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class NoteController : MonoBehaviour {

    private NoteContainer nCont;
    private string title;
    private string content;

    void Start() {
        nCont = FindObjectOfType<NoteContainer>();
    }

    //Finds and copies the note title and contents to local variables
    private void GetDetails(){
        title = GameObject.Find("TitleField").GetComponent<InputField>().text;
        content = GameObject.Find("ContentField").GetComponent<InputField>().text;
    }

    //Get title and content from note fields on canvas
    //Search for matching title
    //If a match is found, delete previous
    public void SaveNote() {
        GetDetails();
        FindAndRemoveDuplicate();
        CreateNoteInstance();
    }

	public void DeleteNoSave() {
		GetDetails();
		FindAndRemoveDuplicate();
	}

	private void FindAndRemoveDuplicate() {
        Note duplicateNote = DuplicateTitleCheck();

        if (duplicateNote != null) {
            Debug.Log(duplicateNote.ToString());
            DeleteNote(duplicateNote);
        }
        else {
            Debug.Log("DeleteNote HAS NOT BEEN called!");
        }
    }

    public void LoadNote() {
        /*TODO: Get title from Note class corresponding to saved note panel
         *      Search for matching title in NoteContainer
         *      Populate title and content fields on NoteWritingCanvas
         *      Save new note to NoteContainer
        */
    }

    //Delete selected note from NoteContainer.noteList
    //@param:   noteToDelete - the note to be deleted
    public void DeleteNote(Note noteToDelete) {
        Debug.Log("DeleteNote called!");
        nCont.RemoveNote(noteToDelete);
    }

    //Search for matching title from note field on canvas
    //Return true if found, else return false
    public Note DuplicateTitleCheck() {
        List<Note> notes = nCont.SendNoteList();
        //if(notes == null) {
        //    return null;
        //}

        foreach (Note duplicateNote in notes) {
            if (duplicateNote.GetTitle() == title) {
                Debug.Log("Duplicate found");
                return duplicateNote;
            }
        }

        Debug.Log("No duplicate found");
        return null;
    }

    //Create new Note with currently selected Title and Content
    private void CreateNoteInstance() {
        nCont.AddNote(new Note(title, content));
    }
}
