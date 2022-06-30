//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...


// Biblioteca online
// 1. registrati
// 2. login

//login 
// email: ..
// passowrd: ..

// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd

// Registrazione
// Scrivmi il nome: 
// scrivimi il cognome.. etc
// scrivi la passowrd: 

// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro


using CSharpBiblioteca;
using System.Linq;

List<User> users = new List<User>()
{
    new Admin("Vitiello", "Alessio", "avitiello@boolean.it", "P4$$w0Rd", 3890124567),
    new User("Margherita", "Laura", "lmargherita@boolean.it", "12345678", 3897564210),
    new User("Mura", "Federico", "fmura@boolean.it", "R3dRuM", 3491256780)
};

List<Book> books = new List<Book>()
{
    new Book(9788891828934, "Libro", "Commedia", 2, 5, new Author("Capatonda", "Maccio"), 222),
    new Book(978-8842075493, "Critica della ragion pura", "Filosofia", 1, 3, new Author("Kant", "Immanuel"), 688)
};

List<DVD> dvds = new List<DVD>()
{
    new DVD(344566784, "Zoolander 2", "I grandi capolavori", 5, 4, new Author("Stiller", "Ben"), 100)
};

List<Document> Catalogue()
{
    List<Document> catalogue = new List<Document>();
    catalogue.AddRange(books);
    catalogue.AddRange(dvds);
    return catalogue;
}

List<Rent> AllRents()
{
    List<Rent> rents = new List<Rent>();
    foreach (User user in users)
    {
        foreach (Rent rent in user.Rents)
        {
            rents.Add(rent);
        }
    }
    return rents;
}