using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteractor : MonoBehaviour
{



    public void DoubleSize(GameObject cube)
    {
        cube.transform.localScale *= 2;
    }
    public void ChangeColorRed(GameObject cube)
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void ChangeColorGreen(GameObject cube)
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.green;
    }
    public void Disappear(GameObject cube)
    {
        cube.SetActive(false);
    }

    public void Rotate360(GameObject cube)
    {
        StartCoroutine(Timer(cube));
    }


    private IEnumerator Timer(GameObject cube)
    {

        yield return new WaitForSeconds(2f);
        cube.GetComponent<Animator>().SetTrigger("Animate");

    }
}
