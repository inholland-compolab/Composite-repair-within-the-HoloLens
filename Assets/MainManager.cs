using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class MainManager : MonoBehaviour
{
    public UnityEvent StepOneFinished, StepTwoFinished, StepThreeFinished;
    public UnityEvent StartButtonPressed;
    public GameObject Step0, Step1, Step2, Step3, Step4, Step5;
    public GameObject Next1;
    public GameObject Previous1;
    public GameObject StartButton;
    public GameObject Hide1;

    public GameObject Marker1, Marker2;


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
        if(StepIndex == 0) { MainMenu();}
        if(StepIndex == 1) { StepZero(); }
        if(StepIndex == 2) { StepOne(); }
        if(StepIndex == 3) { StepTwo(); }
        if(StepIndex == 4) { StepThree(); }
        if(StepIndex == 5) { StepFour(); }
        if(StepIndex == 6) { StepFive(); }

        //Just extend this to the amount of individual steps you have

    }

    public void MainMenu()
    {
        Step0.SetActive(false);
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(false);

        StartButton.SetActive(true);
        Hide1.SetActive(false);
        Next1.SetActive(false);
        Previous1.SetActive(false);

    }
    public void StepZero()
    {
        Step0.SetActive(true);
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(false);

        StartButton.SetActive(false);
        Hide1.SetActive(true);
        Next1.SetActive(true);
        Previous1.SetActive(false);

    }

    public void StepOne()
    {
        Marker1.SetActive(true);
        Marker2.SetActive(true);
        Debug.Log("StepOneInit");
        FindObjectOfType<DistanceCalculator>();
        Step0.SetActive(false);
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
        
        Step0.SetActive(false);
        Step1.SetActive(false);
        Step2.SetActive(true);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(false);
        Previous1.SetActive(true);
        StartButton.SetActive(false);
        Hide1.SetActive(true);
        Next1.SetActive(true);
        Previous1.SetActive(true);

        Marker1.SetActive(false);
        Marker2.SetActive(false);

    }

    public void StepThree()
    {
        Debug.Log("StepThreeInit");
        Step0.SetActive(false);
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(true);
        Step4.SetActive(false);
        Step5.SetActive(false);
        StartButton.SetActive(false);
        Hide1.SetActive(true);
        Next1.SetActive(true);
        Previous1.SetActive(true);
    }

    

        public void StepFour()
    {
        Debug.Log("StepFourInit");
        Step0.SetActive(false);
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(true);
        Step5.SetActive(false);
        StartButton.SetActive(false);
        Hide1.SetActive(true);
        Next1.SetActive(true);
        Previous1.SetActive(true);
    }

    public void StepFive()
    {
        Debug.Log("StepFiveInit");
        Step0.SetActive(false);
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);
        Step5.SetActive(true);
        StartButton.SetActive(false);
        Hide1.SetActive(true);
        Next1.SetActive(true);
        Previous1.SetActive(true);
    }


}

