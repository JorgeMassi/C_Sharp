using ChallengeOne_Medium.Model;

namespace ChallengeOne_Medium.Repository
{

    internal class PhoneRepository : IPhoneRepository
    {

        private static List<Phone> _myPhone = new List<Phone>();

        private static int _id = 1;

        public Phone Create(Phone myPhone)
        {
            myPhone.Id = _id;
            _id++;
            _myPhone.Add(myPhone);
            return myPhone;
        }

        public Phone Retrieve(int id)
        {
            foreach (Phone myPhone in _myPhone)
            {
                if (myPhone.Id.Equals(id))
                {
                    return myPhone;
                }
            }
            throw new KeyNotFoundException("Phone  Id: " + id + " not found!");
        }

        public List<Phone> RetrieveAll()
        {
            return _myPhone;
        }

        public Phone Update(Phone myPhoneToUpdate)
        {
            foreach (Phone myPhone in _myPhone)
            {

                if (myPhone.Id.Equals(myPhoneToUpdate.Id))
                {
                    myPhone.Manufacturer = myPhoneToUpdate.Manufacturer;
                    myPhone.Model = myPhoneToUpdate.Model;
                    myPhone.OperatingSystem = myPhoneToUpdate.OperatingSystem;
                    myPhone.isMobile = myPhoneToUpdate.isMobile;
                    myPhone.Dimension = myPhoneToUpdate.Dimension;
                }
            }
            return myPhoneToUpdate;
        }
        public void Delete(int id)
        {
            Phone phoneToDelete = Retrieve(id);
            _myPhone.Remove(phoneToDelete);
        }
    }
}
