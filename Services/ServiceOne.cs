using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Services
{
    public class ServiceOne
    {
        private readonly List<string> responses = new()
        {
            "It is certain.",
            "Ask again later.",
            "Don't count on it.",
            "Yes, definitely.",
            "My sources say no.",
            "Outlook good.",
            "Very doubtful.",
            "Signs point to yes."
        };
        public string GetRandomResponse()
        {
            var random = new Random();
            int index = random.Next(responses.Count);
            return responses[index];
        }
    }
}