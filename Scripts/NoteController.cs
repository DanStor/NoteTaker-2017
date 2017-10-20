using UnityEngine;
using UnityEngine.UI;

public class NoteController : MonoBehaviour {

    private NoteContainer nCont;
    private string title;
    private string content;

    void Start() {
        nCont = FindObjectOfType<NoteContainer>();
    }

    private void GetDetails() {
        title = GameObject.Find("TitleField").GetComponent<InputField>().text;
        print("Note title is: " + title);
        content = GameObject.Find("ContentField").GetComponent<InputField>().text;
        print("Note content is: " + content);
    }

    public void SaveNote() {
        GetDetails();
        /*TODO: Get title and content from note fields on canvas
         *      Search for matching title
         *      If a match is found, delete previous
         *      Create a new Note class
         *      Save new note to NoteContainer
        */
    }

    public void LoadNote() {
        /*TODO: Get title from Note class corresponding to saved note panel
         *      Search for matching title in NoteContainer
         *      Populate title and content fields on NoteWritingCanvas
         *      Save new note to NoteContainer
        */
    }

    public void DeleteNote() {
        /*TODO: Get title from note field on canvas
         *      Search for matching title to delete from NoteContainer
         *      Delete matching note
         *      If no matching title, do nothing
        */
    }

    public bool NoteTitleSearch() {
        /*TODO: Search for matching title from note field on canvas
         *      Return true if found, else return false
        */
        return true;
    }
}
