using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public string nextScene;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick() {
        Debug.Log("Button Click");
        SceneManager.LoadScene(nextScene);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
