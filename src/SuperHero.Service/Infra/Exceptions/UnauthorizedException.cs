namespace SuperHero.Service.Infra.Exceptions;

public sealed class UnauthorizedException : BaseException
{
    public UnauthorizedException()
    : base()
    {
    }
    public UnauthorizedException(string message)
        : base(message)
    {
    }
    public UnauthorizedException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}