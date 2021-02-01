using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismsController : MonoBehaviour
{
    public TextAsset jsonFile;
    public PrismData pd = new PrismData();

    //flips patrol direction movement
    [HideInInspector]
    public bool moveInitial = true;
    [HideInInspector]
    public int lifeToSub = 1;

    void Start()
    {
        Prisms prismsInJson = JsonUtility.FromJson<Prisms>(jsonFile.text);

        foreach (PrismData prism in prismsInJson.prisms)
        {
            if(prism.prismID == "Red Prism")
            {
                pd.prismID = prism.prismID;
                pd.speed = prism.speed;
                pd.x = prism.x;
                pd.y = prism.y;
                pd.z = prism.z;
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
                pd.x = prism.x;
                pd.y = prism.y;
                pd.z = prism.z;
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
                pd.x = prism.x;
                pd.y = prism.y;
                pd.z = prism.z;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().MinusLife(lifeToSub);
        }
    }
}

   /*     if (this.gameObject.CompareTag("Red Prism") && transform.position.x >= patrol1x)
        {
    moveInitial = false;
}

        if (this.gameObject.CompareTag("Red Prism") && transform.position.x <= patrol2x)
        {
    moveInitial = true;
}

        if (this.gameObject.CompareTag("Green Prism") && transform.position.z >= patrol1z)
        {
    moveInitial = false;
}

        if (this.gameObject.CompareTag("Green Prism") && transform.position.z <= patrol2z)
        {
    moveInitial = true;
}

        if (this.gameObject.CompareTag("Purple Prism") && transform.position.y >= patrol1y)
        {
    moveInitial = false;
}

        if (this.gameObject.CompareTag("Purple Prism") && transform.position.y <= patrol2y)
        {
    moveInitial = true;
} */