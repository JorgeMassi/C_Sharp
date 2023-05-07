using ChallengeOne_Medium.Model;
using ChallengeOne_Medium.Repository;

internal class PhoneService : IPhoneService
{
    private readonly IPhoneRepository _myPhoneRepository = new PhoneRepository();

    public Phone Create(Phone myPhone)
    {
        return _myPhoneRepository.Create(myPhone);
    }

    public Phone Retrieve(int id)
    {
        return _myPhoneRepository.Retrieve(id);
    }

    public List<Phone> RetrieveAll()
    {
        return _myPhoneRepository.RetrieveAll();
    }

    public Phone Update(Phone myPhone)
    {
        return _myPhoneRepository.Update(myPhone);
    }

    public void Delete(int id)
    {
        _myPhoneRepository.Delete(id);
    }



}