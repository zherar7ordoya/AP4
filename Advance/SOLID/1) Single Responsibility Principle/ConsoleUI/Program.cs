using ConsoleUI;

StandardMesssages.WelcomeMessage();

Person user = PersonDataCapture.Capture();

bool isUserValid = PersonValidator.Validate(user);

if (isUserValid is false)
{
    StandardMesssages.EndApplication();
    return;
}

AccountGenerator.CreateAccount(user);

StandardMesssages.EndApplication();