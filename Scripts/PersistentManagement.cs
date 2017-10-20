using UnityEngine;

public class PersistentManagement : MonoBehaviour {

	private void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
}
