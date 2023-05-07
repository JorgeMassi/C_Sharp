using ChallengeOne_Medium.Model;

internal interface IPhoneRepository
{
    Phone Create(Phone myPhone);
    Phone Retrieve(int id);
    List<Phone> RetrieveAll();
    Phone Update(Phone myPhone);
    void Delete(int id);
}