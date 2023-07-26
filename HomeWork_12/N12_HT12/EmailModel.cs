using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace HomeWork_12.N12_HT12;

public class EmailModel
{
    private string _emailTo;
    private string _emailFrom;
    private string _emailSubject;
    private string _emailContent;
    private static readonly Regex _invalidCharactersRegex = new Regex(@"[\r\n]");
    public string EmailTo
    {
        get => _emailTo;
        set
        {
            _emailTo = value;
            CheckEmailToValid(_emailTo);
        }
    }

    public string EmailFrom
    {
        get => _emailFrom;
        set
        {
            _emailFrom = value;
            CheckEmailToValid(_emailFrom);
        }
    }

    public string EmailSubject
    {
        get => _emailSubject;
        set
        {
            _emailSubject = value;
            CheckSubjectOrContentToValid(_emailSubject);
        }
    }

    public string EmailContent
    {
        get => _emailContent;
        set
        {
            _emailContent = value;
            CheckSubjectOrContentToValid(_emailContent);
        }
    }
    

    private void CheckEmailToValid(string email)
    {
        try
        {
            MailAddress mail = new MailAddress(email);
        }
        catch(FormatException)
        {
            Console.WriteLine("Email is not valid");
        }
    }

    private void CheckSubjectOrContentToValid(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
            Console.WriteLine("Subject or Content is not valid");
    }

    public override string ToString()
    {
        return $"Email to: {EmailTo}\n" +
               $"Email from: {EmailFrom}\n" +
               $"Email subject: {EmailSubject}\n" +
               $"Email content: {EmailContent}\n";
    }
}
