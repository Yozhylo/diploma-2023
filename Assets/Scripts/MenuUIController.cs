using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuUIController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable() {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var buttonRoot = root.Q<VisualElement>("buttonHolder");
        //var addAgentButton = root.Q<Button>("AddNewAgent");
        var buttonStart = buttonRoot.Q<Button>("buttonStart");
        buttonStart.clickable.clicked += () =>
        {
            saveValuesToGame();
            SceneManager.LoadScene(1);
        };
        //addAgentButton.clicked += () => FishSpawner.createFish();
    }

    void saveValuesToGame()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        var tankSize = root.Q<Foldout>("Environment").Q<TextField>("tankSize").value;
        var temperature = root.Q<Foldout>("Environment").Q<TextField>("temp").value;
        var acidity = root.Q<Foldout>("Environment").Q<TextField>("acidity").value;
        var ammonia = root.Q<Foldout>("Environment").Q<TextField>("ammonia").value;
        var nitrite = root.Q<Foldout>("Environment").Q<TextField>("nitrite").value;
        var nitrate = root.Q<Foldout>("Environment").Q<TextField>("nitrate").value;
        VariablesPassingToGame.tankSize = float.Parse(tankSize);
        VariablesPassingToGame.temperature = float.Parse(temperature);
        VariablesPassingToGame.acidity = float.Parse(acidity);
        VariablesPassingToGame.ammonia = float.Parse(ammonia);
        VariablesPassingToGame.nitrite = float.Parse(nitrite);
        VariablesPassingToGame.nitrate = float.Parse(nitrate);
    }
}
