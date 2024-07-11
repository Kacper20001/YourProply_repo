using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProply.Services
{
    public class OpenAIService
    {
        private readonly OpenAIAPI _api;
        public OpenAIService(string apiKey)
        {
            _api = new OpenAIAPI(apiKey);
        }

        public async Task<string> AskQuestion(string question)
        {
            var completionRequest = new OpenAI_API.Completions.CompletionRequest
            {
                Prompt = question,
                MaxTokens = 150
            };

            var result = await _api.Completions.CreateCompletionAsync(completionRequest);
            return result.Completions[0].Text;
        }
    }
}
