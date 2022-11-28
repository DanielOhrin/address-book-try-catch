using System.Collections.Generic;

namespace AddressBook
{
    class AddressBook
    {
        private Dictionary<string, Contact> _contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact newContact)
        {
            _contacts.Add(newContact.Email, newContact);
        }

        public Contact GetByEmail(string email)
        {
            return _contacts[email];
        }
    }
}