namespace Mr_Sure21EssentialTools.ValueObjects;

public sealed class Email : ValueObject
{
    public string Value { get; }

    // Parameterless constructor required by EF
    private Email() { }

    private Email(string email)
    {
        Value = email;
    }

    public static Result<Email> Create(string? email, Func<string, bool>? IsEmailUnique = null)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return new Error("Email.Empty", "Email can't be null");
        }

        if (IsEmailUnique is not null && IsEmailUnique?.Invoke(email) == false)
        {
            return new Error("Email.Used", "The email should be unique");
        }

        if (email.Contains('@') == false || email.Contains('.') == false)
        {
            return new Error("Email.Invalid", "Email was not in correct format");
        }

        return new Email(email);
    }    
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
