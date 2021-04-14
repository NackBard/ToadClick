using System;
using System.Collections;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    public GameObject[] tail;
    private Coroutine coroutine;
    private bool horizontal = true, vertical = false;
    Vector3 lastPosition, tailLastPosition;
    public GameObject apple, newtail;
    private void Start()
    {
        coroutine = StartCoroutine(IMove(1, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Food")
        {
            Destroy(other.gameObject);
            Array.Resize(ref tail, tail.Length + 1);
            tail[tail.Length-1] = Instantiate(newtail, new Vector3(tail[tail.Length-2].transform.position.x, tail[tail.Length-2].transform.position.y, tail[tail.Length-2].transform.position.z), Quaternion.identity);
            Instantiate(apple, new Vector3(UnityEngine.Random.Range(-20, 19), UnityEngine.Random.Range(-4, 25), 30.01f), Quaternion.identity);
        }
        else if(other.tag == "Tail")
        {
            var comp = gameObject.GetComponent<SnakeMove>();
            Destroy(comp);
        }
    }
    public void PressButton(string str)
    {
        switch (str)
        {
            case "→":
                if (horizontal == false)
                {
                    horizontal = true;
                    vertical = false;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(IMove(1, 0));
                }
                break;
            case "←":
                if (horizontal == false)
                {
                    horizontal = true;
                    vertical = false;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(IMove(-1, 0));
                }
                break;
            case "↓":
                if (vertical == false)
                {
                    horizontal = false;
                    vertical = true;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(IMove(0, -1));
                }
                break;
            case "↑":
                if (vertical == false)
                {
                    horizontal = false;
                    vertical = true;
                    StopCoroutine(coroutine);
                    coroutine = StartCoroutine(IMove(0, 1));
                }
                break;
        }
    }

    IEnumerator IMove(int valueX, int valueY)
    {
        while (true)
        {
            lastPosition = transform.position;
            transform.position = new Vector3(transform.position.x + valueX, transform.position.y + valueY, transform.position.z);
            for(int i =0; i< tail.Length; i++)
            {
                tailLastPosition = tail[i].transform.position;
                tail[i].transform.position = lastPosition;
                lastPosition = tailLastPosition;
            }
            yield return new WaitForSeconds(0.4f);
        }
    }
}
