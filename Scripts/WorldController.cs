using UnityEngine;

public class WorldController : MonoBehaviour {

    public GameObject mainMenuScene;
    public GameObject noteScene;

    private void Start() {
        LoadMain();
    }

    public void SetScene (string scene) {
        ClearScene();

		if (scene == "mn")
			LoadMain ();
		else if (scene == "nt")
			LoadNote ();
		else
			Debug.LogError ("Invalid scene string", gameObject);
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
}