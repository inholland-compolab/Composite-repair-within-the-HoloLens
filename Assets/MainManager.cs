using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainManager : MonoBehaviour
{
    public UnityEvent StepOneFinished, StepTwoFinished, StepThreeFinished;
    public UnityEvent StartButtonPressed;
    public GameObject Step1, Step2, Step3, Step4;
    public GameObject Next1;
    public GameObject Previous1;
    public GameObject StartButton;


<<<<<<< Updated upstream
    public int StepIndex = 0; //This will keep track of the currently active step of yours where 0 is the start condition and step 1 is stepIndex=1
    public int maxStep = 4;
=======
    public int StepIndex = 0; //This keeps track of which active step is being displayed in the manager object
    public int maxStep = 5;
>>>>>>> Stashed changes


    private void Start()
    {
        Debug.Log("Starting up");
        StepIndex = 0; 
    }

    public void GoToNextStep()  //Calls next step, attached to the next button
    {
        if (StepIndex < maxStep)
        {
            StepIndex++;
        }
        LoadNextStep(StepIndex);
    }


    public void GoToPreviousStep() //Calls previous step, attached to the previous button
    {
        if (StepIndex >= 1)
        {
            StepIndex--;
        }
        LoadNextStep(StepIndex);
    }


    public void LoadNextStep(int step)
    {
        //Number of steps included down below
        StepIndex = step;
        if(StepIndex == 0){ Start();}
        if (StepIndex == 1) { StepOne(); }
        if (StepIndex == 2) { StepTwo(); }
        if (StepIndex == 3) { StepThree(); }
        if (StepIndex == 4) { StepFour(); }
        //if (StepIndex == 5) { StepFive(); }

    }

<<<<<<< Updated upstream
    public void StepOne()
=======
    public void MainMenu() //main menu of the program
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
    public void StepZero() //step zero, also the pop-up to locate the QR-code
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

    public void StepOne() //Step 1, lacing the markers
>>>>>>> Stashed changes
    {
        Debug.Log("StepOneInit");
        FindObjectOfType<DistanceCalculator>();
        Step1.SetActive(true);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(false);

        StartButton.SetActive(false);
        Next1.SetActive(true);
        Previous1.SetActive(false);
        
    }

    public void StepTwo() //Step 2, insert depth
    {
        Debug.Log("StepTwoInit");
        Step1.SetActive(false);
        Step2.SetActive(true);
        Step3.SetActive(false);
        Step4.SetActive(false);

        Previous1.SetActive(true);
        
    }

    public void StepThree() //Step 3, insert plies
    {
        Debug.Log("StepThreeInit");
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(true);
        Step4.SetActive(false);
    }

    

        public void StepFour() //Step 4, calculation of the plies
    {
        Debug.Log("StepFourInit");
        Step1.SetActive(false);
        Step2.SetActive(false);
        Step3.SetActive(false);
        Step4.SetActive(true);
    }

<<<<<<< Updated upstream

=======
    public void StepFive() //Not applicable
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
>>>>>>> Stashed changes


}

