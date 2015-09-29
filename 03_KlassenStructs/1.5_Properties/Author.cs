namespace _1._5_Properties
{
    class Author
    {
        // HINWEIS: Versuchen Sie so wenige Fields wie möglich zu verwenden!

        // TODO: Konstruktur der den Vornamen und Nachnahmen des Autors entgegennimmt.
        public Author(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        
        // TODO: Default-Konstruktor (stellt einen anonymen Autor dar).
        public Author()
        {
            IsAnonymous = true;
        }

        // TODO: Readonly Property für Vornamen.
        public string Firstname { get; private set; }

        // TODO: Readonly Property für Nachnamen.
        public string Lastname { get; private set; }
        
        // TODO: Readonly Property für den vollen Namen (Vor- und Nachnamen kombiniert), Formatierung ist egal
        // Handelt es sich um einen anonymen Autor, soll "anonymous" ausgegeben werden.
        private string fullname;

        public string Fullname
        {
            get 
            {
                if (!IsAnonymous)
                {
                    return Firstname + " " + Lastname;
                } 
                return "anonymous";
            }
            private set
            {
                fullname = value;
            }
        }
        

        // TODO: Property um festzustellen, ob der Autor anonym sein soll
        // Wurde der Default-Konstruktur aufgerufen, ist der Autor immer anonym
        // und der Wert darf nicht verändert werden.
        private bool isAnonymous;

        public bool IsAnonymous
        {
            get { return isAnonymous; }
            set
            { 
                if ((string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(this.Lastname)))
                {
                    isAnonymous = true;
                }
                else
                {
                    isAnonymous = value;
                } 
            }
        }
        
    }
}
