using System;
using UnityEngine;
using UnityEngine.UI;

public class OpenNoteButtonController : MonoBehaviour {

    private NoteController nc;
    private string noteTitle;

    private void Awake() {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ButtonPressed);
    }

    private void Start() {
        nc = FindObjectOfType<NoteController>();
    }

    private void ButtonPressed() {
        OpenThisNote();
    }

    public void GetInfo(string title) {
        noteTitle = title;
        GetComponent<NotePanelTextController>().SetText(title);
	}

    private void OpenThisNote() {
        nc.LoadNote(noteTitle);
    }
}
