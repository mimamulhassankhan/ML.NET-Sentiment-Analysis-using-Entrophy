using MyMLApp;
using System;

namespace myMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = Console.ReadLine()
            };

            // Load model and predict output of sample data
            var result = SentimentModel.Predict(sampleData);

            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            string sentiment = result.Prediction == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
        }
    }
}
