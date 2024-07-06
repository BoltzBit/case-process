namespace Process.Core.DomainObjects;

public class Validations
{
    public static void SizeValidation(string valor, int maximo, string mensagem)
    {
        var length = valor.Trim().Length;

        if (length > maximo) throw new DomainException(mensagem);
    }
}