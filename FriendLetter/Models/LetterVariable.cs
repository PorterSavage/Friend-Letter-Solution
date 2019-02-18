namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _location;
    private string _souviner;
    public string GetRecipient()
    {
      return _recipient;
    }
    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
    public string GetSender()
        {
          return _sender;
        }

    public void SetSender(string newSender)
        {
          _sender = newSender;
        }
    public string GetVacationLocation()
        {
          return _location;
        }
    public void SetLocation(string newLocation)
        {
          _location = newLocation;
        }
        public string GetSouviner()
            {
              return _souviner;
            }
        public void SetSouviner(string newSouviner)
            {
              _souviner = newSouviner;
            }

  }
}
