using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurplePrisms : MonoBehaviour
{
    public PrismsController pc;
    public float secondsToWait;

    private void Start()
    {
        StartCoroutine(ChangeDirectionCoroutine());
    }


    void Update()
    {
        transform.Rotate(pc.pd.x * pc.pd.rotationSpeed * Time.deltaTime, pc.pd.y * pc.pd.rotationSpeed * Time.deltaTime, pc.pd.z * pc.pd.rotationSpeed * Time.deltaTime);

        if (pc.moveInitial)
            transform.Translate(pc.pd.x * pc.pd.speed * Time.deltaTime, pc.pd.y * pc.pd.speed * Time.deltaTime, pc.pd.z * pc.pd.speed * Time.deltaTime);
        else
            transform.Translate(-pc.pd.x * pc.pd.speed * Time.deltaTime, -pc.pd.y * pc.pd.speed * Time.deltaTime, -pc.pd.z * pc.pd.speed * Time.deltaTime);
    }

    IEnumerator ChangeDirectionCoroutine()
    {
        yield return new WaitForSeconds(secondsToWait);
        pc.moveInitial = false;
        StartCoroutine(RevertDirectionCoroutine());
    }

    IEnumerator RevertDirectionCoroutine()
    {
        yield return new WaitForSeconds(secondsToWait);
        pc.moveInitial = true;
        StartCoroutine(ChangeDirectionCoroutine());
    }
}
