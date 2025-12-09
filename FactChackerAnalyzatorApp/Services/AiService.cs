using FactChackerAnalyzatorApp.Models;
using Google.GenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FactChackerAnalyzatorApp.Services
{
    public class AiService
    {
        private readonly string API_KEY = "AIzaSyCYjRc7nEyRB9Ru2T7o9b1lYAPV1avLxSE";
        private string PROMPT_FILE_NAME = "Prompts/default.txt";

        private const string PROMPT_FIELD_TEXT = "#TEXT#";
        private const string PROMPT_FIELD_LINK = "#LINK#";

        private readonly Client _client;
        public AiService()
        {
            _client = new Client(apiKey: API_KEY);
        }

        public async Task<GeminiModel>? BuildText(string text)
        {
            string prompt = System.IO.File.ReadAllText(PROMPT_FILE_NAME);
            prompt = prompt.Replace(PROMPT_FIELD_TEXT, text);

            var result = await _client.Models.GenerateContentAsync(
                model: "gemini-2.5-flash", contents: prompt);

            var json = result?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text;

            if (result is null)
                return null;
            else
                return System.Text.Json.JsonSerializer.Deserialize<GeminiModel>(json);
        }

        public async Task<GeminiModel>? BuldLink(string link)
        {

            string prompt = System.IO.File.ReadAllText(PROMPT_FILE_NAME);
            prompt = prompt.Replace(PROMPT_FIELD_TEXT, link);

            var result = await _client.Models.GenerateContentAsync(
                model: "gemini-2.5-flash", contents: prompt);

            var json = result?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text;

            if (result is null)
                return null;
            else
                return System.Text.Json.JsonSerializer.Deserialize<GeminiModel>(json);

        }


    }
}
