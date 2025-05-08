int temperature = 78;
int toxicity = 40;
int colorCode = 5;
int glowLevel = 6;


int baseScore = (100 - toxicity) + glowLevel * 3 - Math.Abs(colorCode - 7) * 2;


bool Successful = baseScore > 80;
bool Dangerous = toxicity > 70 || temperature > 90;
bool Rare = glowLevel > 7 && colorCode > 7;
bool Worthwhile = Successful && !Dangerous;

if (Successful && Rare) baseScore += 10;

if (temperature - toxicity < 50 ) baseScore -=5;

if (glowLevel == colorCode) baseScore += 7;

if (temperature > 100)  baseScore -=15;

if (toxicity < 30 && glowLevel >= 8 && (temperature > 85 && temperature < 65))
    baseScore += 12;

Console.WriteLine(baseScore);

