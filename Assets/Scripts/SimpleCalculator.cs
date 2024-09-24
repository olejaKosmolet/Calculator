using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleCalculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField _firstValueInput;
    [SerializeField] private TMP_InputField _secondValueInput;
    [SerializeField] private TMP_Text _resultOutput;

    private List<float> ReturnNumbers(TMP_InputField firstNum, TMP_InputField secondNum)
    {
        float firstNumber = float.Parse(_firstValueInput.text);
        float secondNuber = float.Parse(_secondValueInput.text);
        List<float> numbers = new List<float>() { firstNumber, secondNuber };

        return numbers;
    }

    public void AddNumbers()
    {
        List<float> nums = ReturnNumbers(_firstValueInput, _secondValueInput);
        float result = nums[0] + nums[1];
        _resultOutput.text = $"{result}";
    }

    public void SubtractNumbers()
    {
        List<float> nums = ReturnNumbers(_firstValueInput, _secondValueInput);
        float result = nums[0] - nums[1];
        _resultOutput.text = $"{result}";
    }

    public void MultiplyNumbers()
    {
        List<float> nums = ReturnNumbers(_firstValueInput, _secondValueInput);
        float result = nums[0] * nums[1];
        _resultOutput.text = $"{result}";
    }
    
    public void DivideNumbers()
    {
        List<float> nums = ReturnNumbers(_firstValueInput, _secondValueInput);
        float result = nums[0] / nums[1];
        _resultOutput.text = $"{result}";
    }



    public void CleanFields()
    {
        _firstValueInput.text = string.Empty;
        _secondValueInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
}
