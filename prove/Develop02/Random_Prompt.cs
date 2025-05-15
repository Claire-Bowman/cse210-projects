class Random_Prompt
{
    private List<string> prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a challenge you faced recently.",
        "What made you smile today?",
        "Write about a goal you're working on."
    };

    public string RandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}