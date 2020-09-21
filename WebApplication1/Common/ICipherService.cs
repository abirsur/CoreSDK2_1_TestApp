namespace WebApplication1.Common
{
    public interface ICipherService
    {
        string Decrypt(string cipherText);
        string Encrypt(string input);
    }
}