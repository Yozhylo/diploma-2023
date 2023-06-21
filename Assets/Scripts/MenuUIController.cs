using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuUIController : MonoBehaviour
{
  [SerializeField] private VisualTreeAsset asset;
  // Start is called before the first frame update
  private void OnEnable() {
    var root = GetComponent<UIDocument>().rootVisualElement;
    var biotope = root.Q<Foldout>("Biotope");
    var buttonRoot = root.Q<VisualElement>("buttonHolder");
    var addAgentButton = root.Q<Button>("AddNewAgent");
    var buttonStart = buttonRoot.Q<Button>("buttonStart");
    
    
    // int counter = 1;
    addAgentButton.clickable.clicked += () => {
      // biotope.Add(AgentRow);
      // Debug.Log("button clockerd");
      // Debug.Log(counter);

      // Creating a new foldout from template on button click
      // NEED TO MAKE IT NUMERATE FOLDOUTS BASED ON ORDER BEING ADDED
      // OR PROPOSE SOME MAKESHIFT BULLSHIT TO MAKE INSTEAD
      biotope.Add(asset.Instantiate());
      var foldout = biotope.Q<TemplateContainer>("TemplateContainer").Q<Foldout>("DropdownField");
      
      // counter++;
      // Debug.Log(counter);
    };
    buttonStart.clickable.clicked += () => {
      saveValuesToGame();
      SceneManager.LoadScene("Simulation");
    };
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
