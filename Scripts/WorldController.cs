using UnityEngine;

public class WorldController : MonoBehaviour {

    public GameObject mainMenuScene;
    public GameObject noteScene;

    private TitleTextController ttc;
    private ContentTextController ctc;

    private void Start() {
        LoadMain();
    }

    public void SetScene (string scene) {
        ClearScene();
        LoadScene(scene);
	}

    public void SetScene (string scene, Note noteToLoad) {
        ClearScene();
        LoadScene(scene);
        ttc = FindObjectOfType<TitleTextController>();
        ctc = FindObjectOfType<ContentTextController>();
        FillForms(noteToLoad);
    }

	private void LoadMain() {
        Instantiate(mainMenuScene,mainMenuScene.transform.position,Quaternion.identity);

	}

	private void LoadNote() {
        Instantiate(noteScene, mainMenuScene.transform.position, Quaternion.identity);
	}

    private void ClearScene() {
        foreach (Transform obj in FindObjectOfType<Canvas>().GetComponentsInChildren<Transform>()) {
            Destroy(obj.gameObject);
        }
    }

    private void LoadScene(string s) {
        if (s == "mn")
            LoadMain();
        else if (s == "nt")
            LoadNote();
        else
            Debug.LogError("Invalid scene string", gameObject);
    }

    private void FillForms(Note noteToLoad) {
        ttc.FillForm(noteToLoad.GetTitle());
        ctc.FillForm(noteToLoad.GetContent());
    }
}