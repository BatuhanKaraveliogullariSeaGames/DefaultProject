using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideControl : MonoBehaviour
{
    [SerializeField] private GameObject scrollBar;
    [SerializeField] private Canvas canvas;
    private float scrollPosition;
    private float[] positions;
    private float distance;
    private bool isPrevious;
    private bool isComing;

    void Start()
    {
        positions = new float[transform.childCount];

        distance = 1f / (positions.Length - 1f);

        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = distance * i;
        }
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            scrollPosition = scrollBar.GetComponent<Scrollbar>().value;

            //Debug.Log(GetPreviousLevel().name);

            for (int i = 0; i < positions.Length; i++)
            {
                //if (scrollPosition < positions[i] + (distance / 2) && scrollPosition > positions[i] - (distance / 2))
                //{
                //    Debug.Log(transform.GetChild(i).name + " alanda");
                //}
                if(scrollPosition == positions[i])
                {
                    Debug.Log(transform.GetChild(i).name + " alanda");
                }
                else if(scrollPosition > positions[i])// + (distance / 2))
                {
                    Debug.Log(transform.GetChild(i).name + " önceki");

                    SetScaleAndColor(transform.GetChild(i).gameObject,scrollPosition, isPrevious);
                }
                else if(scrollPosition < positions[i])// - (distance / 2))
                {
                    Debug.Log(transform.GetChild(i).name + " sonraki");

                    SetScaleAndColor(transform.GetChild(i).gameObject, scrollPosition, isComing);
                }
            }
        }
        else
        {

            for (int i = 0; i < positions.Length; i++)
            {
                if (scrollPosition < positions[i] + (distance / 2) && scrollPosition > positions[i] - (distance / 2))
                {
                    scrollBar.GetComponent<Scrollbar>().value = positions[i];
                }
            }
        }



        //for (int i = 0; i < positions.Length; i++)
        //{
        //    if (scrollPosition < positions[i] + (distance / 2) && scrollPosition > positions[i] - (distance / 2))
        //    {
        //        transform.GetChild(i).GetComponent<RectTransform>().sizeDelta = new Vector3(739.2f, 1600f);


        //        transform.GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1);

        //        for (int j = 0; j < positions.Length; j++)
        //        {
        //            if (j != i)
        //            {
        //                transform.GetChild(j).GetComponent<RectTransform>().sizeDelta = new Vector3(646.8f, 1400f);

        //                transform.GetChild(j).GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f);
        //            }
        //        }
        //    }
        //}
    }

    private void SetScaleAndColor(GameObject level, float scrollPosition, bool status)
    {
        if(isPrevious)
        {

        }
        else if(isComing)
        {

        }
    }
}
