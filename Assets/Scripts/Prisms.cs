using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Prisms
{
    public PrismData[] prisms;
}

/*
private void Update()
{
    transform.Translate(pd.x * pd.speed * Time.deltaTime, pd.y * pd.speed * Time.deltaTime, pd.z * pd.speed * Time.deltaTime);

    //why doesn't this work? transform.Translate(pd.x, pd.y, pd.z) * pd.speed * Time.deltaTime; 
} */