using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    //public string nextScene;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Button Click");
        SceneManager.LoadScene("MasterScene");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
