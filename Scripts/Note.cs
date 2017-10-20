using UnityEngine;

public class Note : MonoBehaviour {

	private string title;
	private string content;

    public Note (string t, string c) {
        SetTitle(t);
        SetContent(c);
    }

    private void SetTitle(string newTitle) {
		title = newTitle;
	}

    private void SetContent(string newContent) {
		content = newContent;
	}

	public string GetTitle() {
		return title;
	}

	public string GetContent() {
		return content;
	}
}
