using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlants : MonoBehaviour
{
    public GameObject[] plants;
    private float[] x = { -2.38f, -1.21f, -0.01f, 1.16f, 2.35f };
    private float[] y = {4.46f, 3.4f, 2.16f, 1.13f, -0.07f, -1.22f, -2.35f};

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        int a = 5;
        while (true)
        {
            Instantiate(
                plants[Random.Range(0, plants.Length)],
                new Vector3(x[Random.Range(0, x.Length)], y[Random.Range(0, y.Length)], 0),
                Quaternion.Euler(new Vector3(-90, 0, 0)));
            yield return new WaitForSeconds(a * 0.9f);
        }
    }
}
