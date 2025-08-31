namespace Models
{
    internal class ContactBook
    {

        public List<Contact> ContactList
        {
            private get;
            private set;
        }

        public ContactBook(List<Contact> AContact)
        {
            ContactList = AContact;
        }

        public void AddContact(Contact AContact)
        {
            bool duplicity = false;
            foreach (Contact BContact in ContactList)
            {
                if ((AContact.Name == BContact.Name) && (AContact.PhoneNumber == BContact.PhoneNumber) &&
                    (AContact.Email == BContact.Email))
                {
                    duplicity = true;
                }
            }

            if (!duplicity)
            {
                ContactList.Add(AContact);
            }
            else
            {
                throw new ArgumentException("This contact is already registered on your contact book.");
            }
        }
        public void DeleteContact(Guid AId)
        {
            int DeleteIndex = -1;

            for (int i = 0; i < ContactList.Count; i++)
            {
                if (ContactList[i].Id == AId)
                {
                    DeleteIndex = i;
                }
            }
            if ((DeleteIndex == -1))
            {
                throw new ArgumentException("There are no contacts with this id.");
            }
            else
            {
                ContactList.RemoveAt(DeleteIndex);
            }
        }

        public Contact FindContact(Guid AId)
        {

            foreach (Contact AContact in ContactList)
            {
                if (AContact.Id == AId)
                {
                    return AContact;

                }
            }
            throw new ArgumentException("This Id has not been found on your contact list.");
        }

        public void ListContacts()
        {
            System.Console.WriteLine("ID  | NAME  |  PHONE NUMBER  |  EMAIL");
            foreach (Contact AContact in ContactList)
            {
                System.Console.WriteLine($"{AContact.Id}  |  {AContact.Name}  |  {AContact.PhoneNumber}  |  {AContact.Email}");
            }
        }
    }
}