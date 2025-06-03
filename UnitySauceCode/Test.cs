using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int answer1 = 10;
        int answer2 = 5;
        answer1 += answer2;
        
        Debug.Log(answer1);
        Debug.Log(answer2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
