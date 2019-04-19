using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public GameObject option1;
    public GameObject option2;
    private GameObject currentModel;
    private int currentIndex;
    private List<GameObject> models;

    // Start is called before the first frame update
    void Start()
    {
        // create and populate list of model objects
        models = new List<GameObject>();
        if (option1 != null) { models.Add(option1); }
        if (option1 != null) { models.Add(option1); }

        // set default option
        var myModel = Instantiate(option1);
        myModel.transform.parent = this.transform;
        currentModel = option1;
        currentIndex = models.IndexOf(currentModel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoLeft()
    {
        // show models[currentIndex - 1] if currentIndex != 0
        var currentIndex = models.IndexOf(currentModel);
        // Destroy(currentModel)
        // Set new currentModel
        // Instantiate(currentModel)
    }

    void GoRight()
    {
        // show models[currentIndex + 1] if currentIndex != (totalCount - 1)
        var currentIndex = models.IndexOf(currentModel);
        // Destroy(currentModel)
        // Set new currentModel
        // Instantiate(currentModel)
    }
}
