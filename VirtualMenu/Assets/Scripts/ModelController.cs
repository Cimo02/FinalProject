using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    private GameObject currentModel;
    private int currentIndex = 0;
    private List<GameObject> models;

    // Start is called before the first frame update
    void Start()
    {
        // create and populate list of model objects
        models = new List<GameObject>();
        foreach (Transform child in transform)
        {
            models.Add(child.gameObject);
            Debug.Log("Added " + child.gameObject.name);
        }

        // set default option
        currentIndex = 0;
        ShowModel(currentIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLeft()
    {
        Debug.Log("Left");
        if (currentIndex <= 0)
        {
            currentIndex = models.Count - 1;
        }
        else
        {
            currentIndex--;
        }
        ShowModel(currentIndex);
    }

    public void GoRight()
    {
        Debug.Log("Right");
        if (currentIndex >= models.Count - 1)
        {
            currentIndex = 0;
        }
        else
        {
            currentIndex++;
        }
        ShowModel(currentIndex);
    }

    public void ShowModel(int index)
    {
        foreach (GameObject model in models)
        {
            model.SetActive(false);
        }

        models[index].SetActive(true);

        currentIndex = index;

        Debug.Log("Showing New Model, Current Index: " + currentIndex);
    }
}
