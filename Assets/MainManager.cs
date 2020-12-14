using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainManager : MonoBehaviour
{
    public UnityEvent StepOneFinished, StepTwoFinished, StepThreeFinished;
    public UnityEvent StartButtonPressed;
    public GameObject Step1, Step2, Step3, Step4, Step5;
    public GameObject Next1;
    public GameObject Previous1;
    public GameObject StartButton;
    public GameObject Hide1;


    public int StepIndex = 0; //This will keep track of the currently active step of yours where 0 is the start condition and step 1 is stepIndex=1
    public int maxStep = 5;


    private void Start()
    {
        Debug.Log("Starting up");
        //Step1 = GameObject.Find("Step1");
        //Step2 = GameObject.Find("Step2");
        //Step3 = GameObject.Find("Step3");
        //Step2 = GameObject.Find("Step4");


        StepIndex = 0; //We use it again here, in case we want to reset everything

    }

    public void GoToNextStep()  //Call this with your next button
    {
        if (StepIndex < maxStep)
        {
            StepIndex++;
        }
        LoadNextStep(StepIndex);
    }


    public void GoToPreviousStep() //call this with your previous button
    {
        if (StepIndex >= 1)
        {
            StepIndex--;
        }
        LoadNextStep(StepIndex);
    }


    public void LoadNextStep(int step)
    {
        //There are more 'elegant' ways to do this but for something less than 10 individual steps it is just not worth the effort. Hence, this:
        StepIndex = step;
        if(StepIndex == 0){ Start();}
        if (StepIndex == 1) { StepOne(); }
        if (StepIndex == 2) { StepTwo(); }
        if (StepIndex == 3) { StepThree(); }
        if (StepIndex == 4) { StepFour(); }
        if (StepIndex == 5) { StepFive(); }

        //Just extend this to the amount of individual steps you have

    }

    public void StepOne()
    {
        Debug.Log("StepOneInit");
        FindObjectOfType<DistanceCalculator>();
        Step1.SetActive(true);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(false);

        StartButton.SetActive(false);
        Hide1.SetActive(true);
        Next1.SetActive(true);
        Previous1.SetActive(false);
        
    }

    public void StepTwo()
    {
        Debug.Log("StepTwoInit");
        Step1.SetActive(false);
        Step2.SetActive(true);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(false);
        Previous1.SetActive(true);
        
    }

    public void StepThree()
    {
        Debug.Log("StepThreeInit");
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(true);
        Step4.SetActive(false);
        Step5.SetActive(false);
    }

    

        public void StepFour()
    {
        Debug.Log("StepFourInit");
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(true);
        Step5.SetActive(false);
    }

    public void StepFive()
    {
        Debug.Log("StepFiveInit");
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(true);
    }


}

