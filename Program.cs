Task strength = TrainStrength();
Task magic = TrainMagic();
Task agility = TrainAgility();

// Wait for all three training tasks to finish
await Task.WhenAll(strength, magic, agility);

Console.WriteLine("\nAll training finished!");

static async Task TrainStrength()
{
    Console.WriteLine("Training Strength...");

    await Task.Delay(3000);

    Console.WriteLine("Strength training complete");
}

static async Task TrainMagic()
{
    Console.WriteLine("Training Magic...");

    await Task.Delay(2000);

    Console.WriteLine("Magic training complete");
}

static async Task TrainAgility()
{
    Console.WriteLine("Training Agility...");

    await Task.Delay(1000);

    Console.WriteLine("Agility training complete");
}