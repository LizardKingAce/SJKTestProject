using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset jsonFile;
    public PrismData pd = new PrismData();

    void Start()
    {
        

        Prisms prismsInJson = JsonUtility.FromJson<Prisms>(jsonFile.text);

        foreach (PrismData prism in prismsInJson.prisms)
        {
            if(prism.prismID == "Red Prism")
            {
                pd.prismID = prism.prismID;
                pd.speed = prism.speed;
                pd.r = prism.r;
                pd.g = prism.g;
                pd.b = prism.b;
                pd.a = prism.a;

                if(this.gameObject.CompareTag("Red Prism"))
                {
                    gameObject.GetComponent<Renderer>().material.color = new Color(pd.r, pd.g, pd.b, pd.a);
                    return;
                }              
            }

            if (prism.prismID == "Green Prism")
            {
                pd.prismID = prism.prismID;
                pd.speed = prism.speed;
                pd.r = prism.r;
                pd.g = prism.g;
                pd.b = prism.b;
                pd.a = prism.a;

                if (this.gameObject.CompareTag("Green Prism"))
                {
                    gameObject.GetComponent<Renderer>().material.color = new Color(pd.r, pd.g, pd.b, pd.a);
                    return;
                }
            }

            if (prism.prismID == "Purple Prism")
            {
                pd.prismID = prism.prismID;
                pd.speed = prism.speed;
                pd.r = prism.r;
                pd.g = prism.g;
                pd.b = prism.b;
                pd.a = prism.a;

                if (this.gameObject.CompareTag("Purple Prism"))
                {
                    gameObject.GetComponent<Renderer>().material.color = new Color(pd.r, pd.g, pd.b, pd.a);
                    return;
                }
            }
        }
    }
}
