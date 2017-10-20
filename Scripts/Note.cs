using UnityEngine;

public class Note {

	private string title;
	private string content;

    public Note (string t, string c) {
        Debug.Log("New note created!");
        SetTitle(t);
        SetContent(c);
    }

    private void SetTitle(string newTitle) {
		title = newTitle;
        Debug.Log("Note title:" + title);
	}

    private void SetContent(string newContent) {
		content = newContent;
        Debug.Log("Note content:" + content);
	}

	public string GetTitle() {
		return title;
	}

	public string GetContent() {
		return content;
	}
}
