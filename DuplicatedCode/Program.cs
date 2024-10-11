// See https://aka.ms/new-console-template for more information

using DuplicatedCode;

Logger logger = new Logger();

logger.LogError("Error", DateTime.Now);
logger.LogWarning("Warning", DateTime.Now);

Console.ReadKey();

