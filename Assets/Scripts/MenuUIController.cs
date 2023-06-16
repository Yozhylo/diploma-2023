using UnityEngine;
using UnityEngine.UIElements;

public class MenuUIController : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnEnable() {
		var root = GetComponent<UIDocument>().rootVisualElement;
		var addAgentButton = root.Q<Button>("AddNewAgent");

		//addAgentButton.clicked += () => FishSpawner.createFish();
		
	}
}
